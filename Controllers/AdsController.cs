using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiceHeroWebApi.Interfaces;
using ServiceHeroWebApi.Models;
using ServiceHeroWebApi.Services;

namespace ServiceHeroWebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AdsController : ControllerBase
    {

        private readonly HttpClient _client;
        private readonly IService _service;

        public AdsController(IHttpClientFactory factory, IService service)
        {
            _client = factory.CreateClient("Jobstream");
            _service = service;
        }


        // GET: api/v1/<AdsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {


            string date = DateTime.Today.AddMonths(-1).ToShortDateString();

            string endpoint =
                "/stream?date=" + date + "&occupation-concept-id=ScKy_FHB_7wT";

            var result = await _client.GetAsync(endpoint);

            var resultString = await result.Content.ReadAsStringAsync();

            var list = JsonConvert.DeserializeObject<List<JobAdDto>>(resultString);

            await _service.AddNewAds(list);

            return Ok();
        }
    }
}

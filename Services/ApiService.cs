using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceHeroWebApi.Data;
using ServiceHeroWebApi.Interfaces;
using ServiceHeroWebApi.Models;

namespace ServiceHeroWebApi.Services
{
    public class ApiService : IService
    {
        private readonly IMapper _mapper;
        private readonly AdContext _context;

        public ApiService(IMapper mapper, AdContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task AddNewAds(List<JobAdDto> list)
        {
            var newAds = new List<JobAdDto>();
  
            foreach (var ad in list)
            {
                if (ad.removed == false)
                {
                    newAds.Add(ad);
                }
                    
            }
            //SQL db
            //await _context.Database.ExecuteSqlRawAsync("TRUNCATE TABLE [JobAds]");

            //SQLite db
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM [JobAds]");

            var ads = _mapper.Map(newAds);
            await _context.AddRangeAsync(ads);
            await _context.SaveChangesAsync();


        }

    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceHeroWebApi.Models;

namespace ServiceHeroWebApi.Interfaces
{
    public interface IService
    {
        Task AddNewAds(List<JobAdDto> list);
    }
}

using System.Collections.Generic;
using ServiceHeroWebApi.Models;

namespace ServiceHeroWebApi.Interfaces
{
    public interface IMapper
    {
        List<JobAd> Map(List<JobAdDto> list);
    }
}

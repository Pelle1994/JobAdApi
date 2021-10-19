using System.Collections.Generic;
using ServiceHeroWebApi.Interfaces;
using ServiceHeroWebApi.Models;

namespace ServiceHeroWebApi.Services
{
    public class Mapper : IMapper
    {
        public List<JobAd> Map(List<JobAdDto> list)
        {

            var result = new List<JobAd>();
            foreach (var a in list)
            {
                result.Add(new JobAd
                {
                    id = a.id,
                    headline = a.headline,
                    publication_date = a.publication_date,
                    descriptionText = a.description?.text,
                    duration_concept_id = a.duration?.concept_id,
                    duration_label = a.duration?.label,
                    workingHoursType_label = a.working_hours_type?.label,
                    employer_organization_number = a.employer?.organization_number,
                    employer_name = a.employer?.name,
                    employer_workplace = a.employer?.workplace,
                    applicationDetails_email = a.application_details?.email,
                    applicationDetails_url = a.application_details?.url?.ToString(),
                    occupation_concept_id = a.occupation?.concept_id,
                    occupation_label = a.occupation?.label,
                    occupationGroup_concept_id = a.occupation_group?.concept_id,
                    occupationGroup_label = a.occupation_group?.label,
                    workplaceAddress_city = a.workplace_address?.city,
                    workplaceAddress_postcode = a.workplace_address?.postcode,
                    workplaceAddress_street_address = a.workplace_address?.street_address
                });
            }

            return result;
        }
    }
}

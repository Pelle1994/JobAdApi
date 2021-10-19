using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHeroWebApi.Models
{
    [NotMapped]
    public class JobAdDto
    {
        public string id { get; set; }
        public object external_id { get; set; }
        public string webpage_url { get; set; }
        public object logo_url { get; set; }
        public string headline { get; set; }
        public DateTime application_deadline { get; set; }
        public int? number_of_vacancies { get; set; }
        public DescriptionDto description { get; set; }
        public EmploymentTypeDto employment_type { get; set; }
        public SalaryTypeDto salary_type { get; set; }
        public object salary_description { get; set; }
        public DurationDto duration { get; set; }
        public WorkingHoursTypeDto working_hours_type { get; set; }
        public ScopeOfWorkDto scope_of_work { get; set; }
        public object access { get; set; }
        public EmployerDto employer { get; set; }
        public ApplicationDetailsDto application_details { get; set; }
        public bool experience_required { get; set; }
        public bool access_to_own_car { get; set; }
        public bool driving_license_required { get; set; }
        public List<DrivingLicenseDto> driving_license { get; set; }
        public OccupationDto occupation { get; set; }
        public OccupationGroupDto occupation_group { get; set; }
        public OccupationFieldDto occupation_field { get; set; }
        public WorkplaceAddressDto workplace_address { get; set; }
        public MustHaveDto must_have { get; set; }
        public NiceToHaveDto nice_to_have { get; set; }
        public DateTime publication_date { get; set; }
        public DateTime last_publication_date { get; set; }
        public bool removed { get; set; }
        public object removed_date { get; set; }
        public string source_type { get; set; }
        public long? timestamp { get; set; }
    }
    public class DescriptionDto
    {
        public string text { get; set; }
        public string text_formatted { get; set; }
        public object company_information { get; set; }
        public object needs { get; set; }
        public object requirements { get; set; }
        public object conditions { get; set; }
    }

    public class EmploymentTypeDto
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class SalaryTypeDto
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class DurationDto
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class WorkingHoursTypeDto
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class ScopeOfWorkDto
    {
        public int? min { get; set; }
        public int? max { get; set; }
    }

    public class EmployerDto
    {
        public object phone_number { get; set; }
        public object email { get; set; }
        public string url { get; set; }
        public string organization_number { get; set; }
        public string name { get; set; }
        public string workplace { get; set; }
    }

    public class ApplicationDetailsDto
    {
        public object information { get; set; }
        public object reference { get; set; }
        public string email { get; set; }
        public bool via_af { get; set; }
        public object url { get; set; }
        public object other { get; set; }
    }

    public class DrivingLicenseDto
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class OccupationDto
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class OccupationGroupDto
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class OccupationFieldDto
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class WorkplaceAddressDto
    {
        public string municipality { get; set; }
        public string municipality_code { get; set; }
        public string municipality_concept_id { get; set; }
        public string region { get; set; }
        public string region_code { get; set; }
        public string region_concept_id { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string country_concept_id { get; set; }
        public string street_address { get; set; }
        public string postcode { get; set; }
        public string city { get; set; }
        public List<double?> coordinates { get; set; }
    }

    public class MustHaveDto
    {
        public List<object> skills { get; set; }
        public List<object> languages { get; set; }
        public List<object> work_experiences { get; set; }
    }

    public class WorkExperienceDto
    {
        public int? weight { get; set; }
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class NiceToHaveDto
    {
        public List<object> skills { get; set; }
        public List<object> languages { get; set; }
        public List<WorkExperienceDto> work_experiences { get; set; }
    }



}

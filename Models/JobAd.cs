using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHeroWebApi.Models
{
    public class JobAd
    {
        [Key] public string id { get; set; }
        public string headline { get; set; }
        public DateTime publication_date { get; set; }
        public string descriptionText { get; set; }
        public string duration_concept_id { get; set; }
        public string duration_label { get; set; }
        public string workingHoursType_label { get; set; }
        public string employer_organization_number { get; set; }
        public string employer_name { get; set; }
        public string employer_workplace { get; set; }
        public string applicationDetails_email { get; set; }
        public string applicationDetails_url { get; set; }
        public string occupation_concept_id { get; set; }
        public string occupation_label { get; set; }
        public string occupationGroup_concept_id { get; set; }
        public string occupationGroup_label { get; set; }
        public string workplaceAddress_street_address { get; set; }
        public string workplaceAddress_postcode { get; set; }
        public string workplaceAddress_city { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWebApp.Models
{
    public class ClientFilter : Client
    {
        public string SortOrder { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string GuidRegion { get; set; }
        public string GuidCity { get; set; }
        public string GuidClassification { get; set; }
        public string GuidSeller { get; set; }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFL_Sharp_v2
{
    public class LineDetails
    {
        [JsonProperty("$type")]
        public string Type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string modeName { get; set; }
        public List<object> disruptions { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public List<LineStatus> lineStatuses { get; set; }
        public List<object> routeSections { get; set; }
        //public List<ServiceType> serviceTypes { get; set; }
        //public Crowding crowding { get; set; }
    }
    public class LineStatus
    {
        [JsonProperty("$type")]
        public string Type { get; set; }
        public int id { get; set; }
        public int statusSeverity { get; set; }
        public string statusSeverityDescription { get; set; }
        public string reason { get; set; }
        public DateTime created { get; set; }
        public List<object> validityPeriods { get; set; }
    }

}

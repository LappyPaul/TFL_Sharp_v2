using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFL_Sharp_v2
{
    public class StationData
    {
        [JsonProperty("$type")]
        public string Type { get; set; }
        public string naptanId { get; set; }
        public List<object> modes { get; set; }
        public string icsCode { get; set; }
        public string stationNaptan { get; set; }
        public List<object> lines { get; set; }
        public List<object> lineGroup { get; set; }
        public List<object> lineModeGroups { get; set; }
        public bool status { get; set; }
        public string id { get; set; }
        public string commonName { get; set; }
        public string placeType { get; set; }
        public List<additionalProperties> additionalProperties { get; set; }
        public List<object> children { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string hubNaptanCode { get; set; }
        public string indicator { get; set; }
    }

    public class additionalProperties
    {
        [JsonProperty("$type")]
        public string category { get; set; }
        public string key { get; set; }
        //public string sourceSystemKey { get; set; }
        public string value { get; set; }
    }
}

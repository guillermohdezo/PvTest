using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvTests.Models.Entity
{
    public class DepResponce
    {
        [JsonProperty(PropertyName = "IdDepartamento")]
        public int DepId { get; set; }
        [JsonProperty(PropertyName = "Descripcion")]
        public string Description { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Response
{
    public class ErrorObject
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("details")]
        public object Details { get; set; }
    }
}

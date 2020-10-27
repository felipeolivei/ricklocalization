using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Response
{
    public class ApiResponseObject<T>
    {
        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        public ErrorObject Error { get; set; }
    }
}

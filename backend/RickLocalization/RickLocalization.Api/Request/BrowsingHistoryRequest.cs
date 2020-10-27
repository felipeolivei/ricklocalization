using AutoMapper;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Request
{
    [AutoMap(typeof(BrowsingHistory))]
    public class BrowsingHistoryRequest
    {
        public int DimensionFromId { get; set; }
        public int DimensionToId { get; set; }
    }
}

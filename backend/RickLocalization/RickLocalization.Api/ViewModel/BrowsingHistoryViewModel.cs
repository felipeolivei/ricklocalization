using AutoMapper;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.ViewModel
{
    [AutoMap(typeof(BrowsingHistory))]
    public class BrowsingHistoryViewModel
    {
        public int DimensionFromId { get; set; }
        public virtual DimensionViewModel DimensionFrom { get; set; }
        public int DimensionToId { get; set; }
        public virtual DimensionViewModel DimensionTo { get; set; }
    }
}

using AutoMapper;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.ViewModel
{
    [AutoMap(typeof(Dimension))]
    public class DimensionViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}

using AutoMapper;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.ViewModel
{
    [AutoMap(typeof(Dimension))]
    public class DimensionListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}

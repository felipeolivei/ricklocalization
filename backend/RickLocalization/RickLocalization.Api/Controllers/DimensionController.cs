using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Api.ViewModel;
using RickLocalization.Business.Services;
using RickLocalization.Model;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DimensionController : BaseController
    {
        private readonly IDimensionService _dimensionService;
        private readonly IMapper _mapper;

        public DimensionController(IDimensionService dimensionService,
            IMapper mapper)
        {
            _dimensionService = dimensionService;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public IActionResult GetAll(int? take, int? skip)
        {
            try
            {
                var list = _dimensionService.GetAll();
                var listVM = _mapper.Map<IEnumerable<DimensionListViewModel>>(list);
                int totalItens = listVM.Count();

                if (skip.HasValue)
                    listVM = listVM.Skip(skip.Value);
                if (take.HasValue)
                    listVM = listVM.Take(take.Value);

                return Success(new { Items = listVM, totalCount = totalItens });
            }
            catch (Exception ex)
            {
                return Error(ex.Message, null);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var entity = _dimensionService.Get(id);

                return Success(_mapper.Map<DimensionViewModel>(entity));
            }
            catch (Exception ex)
            {
                return Error(ex.Message, null);
            }
        }


    }
}
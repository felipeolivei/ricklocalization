using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using RickLocalization.Api.Request;
using RickLocalization.Api.ViewModel;
using RickLocalization.Business.Services;
using RickLocalization.Model;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrowsingHistoryController : BaseController
    {
        private readonly IBrowsingHistoryService _browsingHistoryService;
        private readonly IMapper _mapper;

        public BrowsingHistoryController(IBrowsingHistoryService browsingHistoryService,
            IMapper mapper)
        {
            _browsingHistoryService = browsingHistoryService;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            try
            {
                var list = _browsingHistoryService.GetHistory();

                if (list.Count() > 0)
                {
                    var listVM = _mapper.Map<IEnumerable<BrowsingHistoryViewModel>>(list);
                    int totalItens = listVM.Count();

                    return Success(new { Items = listVM, totalCount = totalItens });
                }
                else
                    return Success(new { Items = new List<BrowsingHistoryViewModel>(), totalCount = 0 });
            }
            catch (Exception ex)
            {
                return Error(ex.Message, null);
            }
        }

        [HttpPost("")]
        public IActionResult Post([FromBody]BrowsingHistoryRequest entity)
        {
            try
            {
                var mapper = new MapperConfiguration(c =>
                {
                    c.CreateMap<BrowsingHistoryRequest, BrowsingHistory>();
                }).CreateMapper();

                _browsingHistoryService.Add(mapper.Map<BrowsingHistoryRequest, BrowsingHistory>(entity));
                return Success(Ok());
            }
            catch (Exception ex)
            {
                return Error(ex.Message, null);
            }
        }

    }
}
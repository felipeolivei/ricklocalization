using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Api.Response;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        [NonAction]
        public virtual OkObjectResult Success<T>(T result)
        {
            return Ok(new ApiResponseObject<T>()
            {
                Success = true,
                Result = result,
                Error = null,
            });
        }

        [NonAction]
        public virtual BadRequestObjectResult Error(string message, object error)
        {
            return BadRequest(new ApiResponseObject<object>()
            {
                Success = false,
                Result = null,
                Error = new ErrorObject()
                {
                    Message = message,
                    Details = error
                }
            });
        }
    }
}
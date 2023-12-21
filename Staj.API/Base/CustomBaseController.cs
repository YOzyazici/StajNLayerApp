using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Staj.Core.Dtos;

namespace Staj.API.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponceDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode= response.StatusCode,
                };
            return new ObjectResult(response) { StatusCode= response.StatusCode };
        }

    }
}

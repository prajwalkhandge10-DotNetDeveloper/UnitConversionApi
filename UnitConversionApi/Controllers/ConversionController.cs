using Microsoft.AspNetCore.Mvc;
using UnitConversionApi.Models;
using UnitConversionApi.Services;

namespace UnitConversionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _service;

        public ConversionController(IConversionService service)
        {
            _service = service;
        }

        [HttpPost("convert")]
        public IActionResult Convert(ConversionRequest request)
        {
            var result = _service.Convert(request);

            return Ok(result);
        }
    }
}

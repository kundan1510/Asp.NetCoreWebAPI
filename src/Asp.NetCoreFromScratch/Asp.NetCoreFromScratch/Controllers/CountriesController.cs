using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreFromScratch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [BindProperty]
        public string Name { get; set; }
        //public int Population { get; set; }
        //public int Area { get; set; }

        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok(this.Name);
        }
    }
}

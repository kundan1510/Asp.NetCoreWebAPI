using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreFromScratch.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //[Route("~/api/get-all")]
        //[Route("~/get-all")]
        [Route("getall")]
        public string GetAll()
        {
            return "hello from get all";
        }

        [Route("api/get-all-authors")]
        //[Route("getall")]  //this is not possible
        public string GetAllAuthors()
        {
            return "hello from get all authors";
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreFromScratch.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //[Route("~/api/get-all")]
        [Route("get-all")]
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

        [Route("books/{id}")]
        //[Route("{id}")]
        public string GetById(int id)
        {
            return "hello " + id;
        }

        [Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "hello author address " + id + " " + authorId;
        }

        [Route("search")]
        public string SeacrhBooks(int id, int authorId, string name, int rating, int price)
        {
            return "hello from search";
        }
    }
}

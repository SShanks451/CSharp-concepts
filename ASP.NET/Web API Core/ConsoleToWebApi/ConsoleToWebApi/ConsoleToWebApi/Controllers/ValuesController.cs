using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
   
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [Route("~/api/get-all")]
        [Route("~/getall")]
        [Route("~/get-all")]
        public string GetAll()
        {
            return "hello from get all";
        }

        //[Route("api/get-all-authors")]
        // [Route("get-all")] ----> this is not possible
        public string GetAllAuthors()
        {
            return "hello from get all authors";
        }

        //[Route("books/{id}")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "hello " + id;
        }

        //[Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddress(int id, int authorId)
        {
            return "hello author address " + id + " " + authorId;
        }

        //[Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return "hello from search";
        }
    }
}

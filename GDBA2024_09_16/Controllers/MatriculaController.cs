using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GDBA2024_09_16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : Controller
    {
        static List<object> data = new List<object>();
        // GET: MatriculaController
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<object> Get()
        {
            return data;
        }

        // GET: MatriculaController/Details/5
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post(string name, string lastName)
        {
            data.Add(new { name, lastName });
            return Ok();
        }

        // GET: MatriculaController/Create
        [Authorize]
        [HttpDelete]
        public IActionResult Delete()
        {
            data = new List<object>();
            return Ok();
        }
    }
}

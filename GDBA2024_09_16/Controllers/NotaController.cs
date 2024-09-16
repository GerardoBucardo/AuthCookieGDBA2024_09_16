using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GDBA2024_09_16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotaController : Controller
    {
        // GET: NotaController
        static List<object> data = new List<object>();

        [HttpGet]
        public IEnumerable<object> Get()
        {
            return data;
        }

        // GET: NotaController/Details/5
        [HttpPost]
        public IActionResult Post(string name, string lastName)
        {
            data.Add(new { name, lastName });
            return Ok();
        }
    }
}

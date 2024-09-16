using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GDBA2024_09_16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        // GET: AccountController
        [HttpPost("login")]
        public ActionResult Login(string login, string password)
        {
            if(login == "admin" && password == "12345")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login),
                };
                var claimsIdentity = new ClaimsIdentity(claims, 
                    CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {

                };

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), authProperties);

                return Ok("Inició sesión correctamente.");
            }
            else
            {
                return Unauthorized("Credenciales incorrectas");
            }
        }

        // GET: AccountController/Details/5
        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok("Cerró sesión correctamente");
        }
    }
}

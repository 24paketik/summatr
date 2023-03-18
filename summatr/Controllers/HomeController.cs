using Microsoft.AspNetCore.Mvc;
using summatr.Models;
using System.Diagnostics;

namespace summatr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task Index()
        {
            string form = @"<form method='post'>
                <p><input type='number' name='m11' /> <input type='number' name='m12' /></p>
                <p><input type='number' name='m13' /> <input type='number' name='m14' /></p>
                <br>

                <p><input type='number' name='m21' /> <input type='number' name='m22' /></p>
                <p><input type='number' name='m23' /> <input type='number' name='m24' /></p>
                <input type='submit' value='Send' />
            </form>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(form);
        }
        [HttpPost]
        public string Index(int m11, int m12, int m13, int m14, int m21, int m22, int m23, int m24)
        {
            string result = "";
            int m31 = m11 + m21;
            int m32 = m12 + m22;
            int m33 = m13 + m23;
            int m34 = m14 + m24;

            result = $"{m31} {m32}  {m33} {m34}";

            return result;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
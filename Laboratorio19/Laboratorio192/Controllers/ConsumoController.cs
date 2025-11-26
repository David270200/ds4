using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Laboratorio19_2.Controllers
{
    public class ConsumoController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string url = "https://localhost:44363/api/values/Get";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var resultado = await response.Content.ReadAsStringAsync();

                ViewBag.Resultado = resultado;
            }

            return View();
        }
    }
}

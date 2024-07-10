using Frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;

        }

        public async Task<IActionResult> Index(int id)
        {
            if (id == 0) { return RedirectToAction("Index","Home"); }
            
            HttpClient client = _clientFactory.CreateClient();

            var response = await client.GetAsync($"https://localhost:7275/api/product?id={id}");
            if (response.IsSuccessStatusCode)
            {
                var product = await response.Content.ReadFromJsonAsync<Product>();
                ViewBag.Product = product;
                return View();
            }
            else
            {
                return StatusCode((int)response.StatusCode, $"API request failed: {response.ReasonPhrase}");

            }


        }
    }
}

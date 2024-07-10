using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;

        }

        public async Task<IActionResult> Index(string? name)
        {
            try
            {
                var client = _clientFactory.CreateClient();

                string productPath = string.Empty;
                if (name == null) productPath = "https://localhost:7275/api/product";
                else productPath = $"https://localhost:7275/api/product?category={name}";

                HttpResponseMessage response = await client.GetAsync(productPath);

                if (response.IsSuccessStatusCode)
                {
                    var products = await response.Content.ReadFromJsonAsync<List<Product>>();
                    ViewBag.Products = products;
                }
                else
                {
                    return StatusCode((int)response.StatusCode, $"API request failed: {response.ReasonPhrase}");
                }

                HttpResponseMessage response2 = await client.GetAsync("https://localhost:7275/api/category");

                if (response2.IsSuccessStatusCode)
                {
                    var categories = await response2.Content.ReadFromJsonAsync<List<Category>>();
                    ViewBag.Categories = categories;
                }
                else
                {
                    return StatusCode((int)response.StatusCode, $"API request failed: {response.ReasonPhrase}");
                }

                return View();
            }
            catch (Exception ex) {
                throw ex;
            }

        }

    }
}
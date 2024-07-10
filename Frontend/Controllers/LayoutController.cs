using Frontend.Models;
using Microsoft.AspNetCore.Mvc;

public class LayoutController : Controller
{
    private readonly IHttpClientFactory _clientFactory;

    public LayoutController(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
    }

    [HttpGet("get")]
    public async Task<ActionResult> GetCategoriesPartial()
    {
        var client = _clientFactory.CreateClient();
        try
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:7255/api/Category");

            if (response.IsSuccessStatusCode)
            {
                var categories = await response.Content.ReadFromJsonAsync<List<Category>>();
                return Ok(categories);
            }
            else
            {
                return StatusCode((int)response.StatusCode, $"API request failed: {response.ReasonPhrase}");
            }
        }
        catch (HttpRequestException ex)
        {
            return StatusCode(500, $"API request failed: {ex.Message}");
        }
    }
}

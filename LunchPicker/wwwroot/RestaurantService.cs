using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class RestaurantService
{
    private readonly HttpClient _http;

    public RestaurantService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Restaurant>> GetRestaurantsAsync()
    {
        return await _http.GetFromJsonAsync<List<Restaurant>>("restaurants.json");
    }
}

public class Restaurant
{
    public string Name { get; set; }
    public string Location { get; set; }
}
using System.Net.Http.Json;
using LunchPicker.Models;

public class RestaurantService
{
    private readonly HttpClient _http;

    public RestaurantService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Restaurant>> GetRestaurantsAsync()
    {
        var restaurants = await _http.GetFromJsonAsync<List<Restaurant>>("sample-data/restaurants.json");
        return restaurants ?? new List<Restaurant>();
    }
}
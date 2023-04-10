using Newtonsoft.Json;

namespace time;

public static class CurrentWeather
{
    public static async Task Get(string defaultCity = "Oslo")
    {
        //// Weather API
        const string apiKey = "f744e7e614a6a198e702ef25b98322c0";
        var httpClient = new HttpClient();
        
        string request = $"http://api.weatherstack.com/current?access_key={apiKey}&query={defaultCity}";
        HttpResponseMessage response = await httpClient.GetAsync(request); // Fallback - bad request handling is needed
        var jsonData = await response.Content.ReadAsStringAsync();
        WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonData);
        
        if (weatherData.Current != null)
        {
            var (temperature, feelsLike) = (weatherData.Current.Temperature, weatherData.Current.FeelsLike);
            Console.WriteLine($"The current temperature in {defaultCity} is {temperature} but feels like {feelsLike}");
        }
    }
}

internal class Current
{
    public int Temperature { get; set; }
    public int FeelsLike { get; set; }
}

internal class WeatherData
{
    public Current? Current { get; set; }
}
using System.Text.Json;

namespace Astronomy;

public class SunriseService
{
    const string SunriseSunsetServiceUrl = "https://api.sunrise-sunset.org";

    public async Task<(DateTime Sunrise, DateTime Sunset)> GetSunriseSunsetTimes(double latitude, double longitude)
    {
        var query = $"{SunriseSunsetServiceUrl}/json?lat={latitude}&lng={longitude}&date=today";

        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        var json = await client.GetStringAsync(query);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var data = JsonSerializer.Deserialize<SunriseSunsetData>(json, options);

        return (DateTime.Parse(data.Results.Sunrise), DateTime.Parse(data.Results.Sunset));
    }

    class SunriseSunsetData
    {
#pragma warning disable 0649
        // Field is only set via JSON deserialization, so disable warning that the field is never set.
        //public SunriseSunsetResults Results;
        public SunriseSunsetResults Results { get; set; }
#pragma warning restore 0649
    }

    class SunriseSunsetResults
    {
#pragma warning disable 0649
        // Fields are only set via JSON deserialization, so disable warning that the fields are never set.
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
#pragma warning restore 0649
    }
}
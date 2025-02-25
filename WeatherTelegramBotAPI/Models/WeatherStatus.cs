namespace WeatherTelegramBotAPI.Models;

public class WeatherStatus
{
    public string City { get; set; }
    public string Country { get; set; }
    public int TemperatureCelcius { get; set; }
    public int TemperatureFahrenheit{ get; set; }
    public int Humidity { get; set; }
}

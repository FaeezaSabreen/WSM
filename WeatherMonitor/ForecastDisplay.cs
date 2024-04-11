namespace WeatherMonitor;


// ForecastDisplay class
public class ForecastDisplay : IDisplay
{
    private WeatherData weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        this.weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        // Update display when weather data changes
        Display();
    }

    public void Display()
    {
        // Display weather forecast
        // Implement logic for forecasting and displaying forecast
    }
}
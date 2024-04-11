namespace WeatherMonitor;

// StatisticsDisplay class
public class StatisticsDisplay : IDisplay
{
    private WeatherData weatherData;

    public StatisticsDisplay(WeatherData weatherData)
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
        // Display weather statistics
        // Implement logic for calculating and displaying statistics
    }
}
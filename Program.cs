namespace time;

public static class Program
{
    public static async Task Main(string[] args)
    {
        // TODO: Change info based on city from args

        DateAndTimeGreeting.WriteGreeting();
        await CurrentWeather.Get();
    }
}


namespace time;

public static class DateAndTimeGreeting
{
    public static void WriteGreeting()
    {
        DateTime currentTime = DateTime.Now;
        DateTime morningTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 6, 0, 0);
        DateTime afternoonTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 12, 0, 0);
        DateTime eveningTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 18, 0, 0);
        DateTime nighTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);

        // Greeting based on time of day  
        if (currentTime >= morningTime && currentTime < afternoonTime)
        {
            Console.WriteLine("Good morning!");
        }
        else if (currentTime >= afternoonTime && currentTime < eveningTime)
        {
            Console.WriteLine("Good afternoon!");
        }
        else if (currentTime >= eveningTime && currentTime < nighTime)
        {
            Console.WriteLine("Good evening!");
        }
        else
        {
            Console.WriteLine("It is nighttime. Be quiet");
        }

        // Output time and date
        Console.WriteLine($"Clock: [{ DateTime.Now:HH:mm}]");
        Console.WriteLine($"Date: [{currentTime.Date:dd/MM/yyyy}]");
    }
}


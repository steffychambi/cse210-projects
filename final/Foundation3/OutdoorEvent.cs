public class OutdoorEvent : Event
{
    private string _weather;
    
    public OutdoorEvent(string title, string date, string time, Address address): base (title, date, time, address)
    {
        _type = "Outdoor Gathering Event";
        _title = title;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public void ShowFullDetails()
    {
        Console.WriteLine($"'Full Details'");
        Console.WriteLine($"title: {_title}");
        Console.WriteLine($"type: {_type}");
        Console.WriteLine($"description: {_description}");
        Console.WriteLine($"date: {_date}");
        Console.WriteLine($"time: {_time}");
        Console.WriteLine($"address: {_address.ReturnAddress()}");
        Console.WriteLine($"weather: {_weather}");
    }
}
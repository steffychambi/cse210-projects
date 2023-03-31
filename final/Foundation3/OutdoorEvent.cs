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
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.ReturnAddress()}");
        Console.WriteLine($"Weather: {_weather}");
    }
}
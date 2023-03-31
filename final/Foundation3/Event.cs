public class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string date, string time, Address address)
    {
        _title = title;
        _date = date;
        _time = time;
        _address = address;
    }
    
    public void SetDescription(string description)
    {
        _description = description;
    }

    public void ShowStandardDetails()
    {
        Console.WriteLine($"'Standard Details'");
        Console.WriteLine($"title: {_title}");
        Console.WriteLine($"description: {_description}");
        Console.WriteLine($"date: {_date}");
        Console.WriteLine($"time: {_time}");
        Console.WriteLine($"address: {_address.ReturnAddress()}");
    }

    public void ShowShortDescription()
    {
        Console.WriteLine($"'Short Description'");
        Console.WriteLine($"type of event: {_type}");
        Console.WriteLine($"title: {_title}");
        Console.WriteLine($"date: {_date}");
    }
}
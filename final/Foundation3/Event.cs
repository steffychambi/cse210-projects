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
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.ReturnAddress()}");
    }

    public void ShowShortDescription()
    {
        Console.WriteLine($"'Short Description'");
        Console.WriteLine($"Type of event: {_type}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}
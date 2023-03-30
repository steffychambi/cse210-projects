public class ReceptionEvent : Event
{
    private string _email;
    
    public ReceptionEvent(string title, string date, string time, Address address): base (title, date, time, address)
    {
        _type = "Reception Event";
        _title = title;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }

    public void ShowFullDetails()
    {
        Console.WriteLine($"'Full Details'");
        Console.WriteLine($"title: {_title}");
        Console.WriteLine($"type: {_type}");
        Console.WriteLine($"description: {_description}");
        Console.WriteLine($"date: {_date}");
        Console.WriteLine($"time: {_time}");
        Console.WriteLine($"address: {_address}");
        Console.WriteLine($"email for RSVP: {_email}");
    }
}
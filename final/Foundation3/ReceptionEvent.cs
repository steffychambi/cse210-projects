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
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.ReturnAddress()}");
        Console.WriteLine($"Email for RSVP: {_email}");
    }
}
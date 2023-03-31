public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;
    
    public LectureEvent(string title, string date, string time, Address address): base (title, date, time, address)
    {
        _type = "Lecture Event";
    }

    public void SetSpeakerName(string name)
    {
        _speakerName = name;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
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
        Console.WriteLine($"Speaker Name: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity} peolple");
    }
        
}
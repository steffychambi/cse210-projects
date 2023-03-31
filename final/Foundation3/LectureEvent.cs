public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;
    
    public LectureEvent(string title, string date, string time, Address address): base (title, date, time, address)
    {
        _type = "Lecture Event";
        _title = title;
        _date = date;
        _time = time;
        _address = address;
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
        Console.WriteLine($"title: {_title}");
        Console.WriteLine($"type: {_type}");
        Console.WriteLine($"description: {_description}");
        Console.WriteLine($"date: {_date}");
        Console.WriteLine($"time: {_time}");
        Console.WriteLine($"address: {_address.ReturnAddress()}");
        Console.WriteLine($"Speaker Name: {_speakerName}");
        Console.WriteLine($"capacity: {_capacity} peolple");
    }
        
}
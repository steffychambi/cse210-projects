public abstract class Activity
{
    protected string _type;
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


    public string GetSummary()
    {
        string summary = $"{_date} {_type} ({_length}) - Distance: {GetDistance()}km Speed: {GetSpeed()}kph Pace: {GetPace()} min per km";
        return summary;
    }
}
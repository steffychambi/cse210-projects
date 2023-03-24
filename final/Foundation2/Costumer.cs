public class Costumer
{
    private string _name;
    private Address _address;

    public Costumer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.ReturnAddress();
    }

    public bool LiveInUsa()
    {
        return _address.IsInUsa();
    }
}
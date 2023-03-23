public class Costumer
{
    private string _name;
    private Address _address;

    Costumer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUsa()
    {
        return _address.IsInUsa();
    }
}
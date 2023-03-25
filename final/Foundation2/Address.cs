public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUsa()
    {
        if(_country == "United States")
        {
            return true;
        }
        else if(_country == "USA")
        {
            return true;
        }
        else if(_country == "United States of America")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public string ReturnAddress()
    {
        string AddressString = $"{_street}, {_city}, {_state}, {_country}";
        return AddressString;
    }
}
using System.ComponentModel;

public class Address
{

    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _city = city;
        _country = country;
        _stateOrProvince = stateOrProvince;
        _street = street;
    }

    public string Country()
    {
        return _country;
    }


    public void DisplayAll()
    {
        Console.WriteLine($"Address: {_street}, {_city}, {_stateOrProvince}, {_country}");
    }
}
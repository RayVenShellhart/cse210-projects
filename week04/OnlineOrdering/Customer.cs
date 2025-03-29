using System.Runtime.CompilerServices;

public class Customer
{
    private bool _ifCountry;
    private string _customer;



    public Customer(string Customer)
    {
        _customer = Customer;
    }

    public bool Country(Address address)
    {
        if (address.Country() == "USA")
        {
            _ifCountry = true;
        }
        return _ifCountry;
    }

    public bool CheckCountry()
    {
        return _ifCountry;
    } 

    public void DisplayAll()
    {
        Console.WriteLine($"    Customer name: {_customer}");
        Console.Write("    Cusotmer Address: ");
    }
}
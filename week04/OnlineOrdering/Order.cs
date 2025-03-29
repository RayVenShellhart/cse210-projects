using System.Data;

public class Order
{
    private int _total;
    private int _fetch;
    private int _fetch1;
    private int _fetch2;
    private string _numbers;
    private string _numbers1;
    private string _number2;



    public void DisplayAll(Product product, Product product1, Customer customer, Address address)
    {
        Console.WriteLine("\n\nNext Costumer");
        Console.Write($"Final Price: ");
        _numbers = product.GetProduct();
        _fetch = int.Parse(_numbers);
        _numbers1 = product1.GetProduct();
        _fetch1 = int.Parse(_numbers1);
        _total = _fetch1 + _fetch;
        if (address.Country() != "USA")
        {
            _total = _total + 35;
        }
        Console.Write(_total);
        Console.WriteLine(". $35 Dollars were added on if outside USA.");
        Console.WriteLine("\nPacking Label:");
        product.DisplayAll();
        product1.DisplayAll();
        Console.WriteLine("\nShipping Label:");
        customer.DisplayAll();
        address.DisplayAll();
    }
    public void DisplayAllLarge(Product product, Product product1, Product product2, Customer customer, Address address)
    {
        Console.WriteLine("\n\nNext Costumer");
        Console.Write($"Final Price: ");
        _numbers = product.GetProduct();
        _fetch = int.Parse(_numbers);
        _numbers1 = product1.GetProduct();
        _fetch1 = int.Parse(_numbers1);
        _number2 = product2.GetProduct();
        _fetch2 = int.Parse(_number2);
        _total = _fetch1 + _fetch + _fetch2;
        if (address.Country() != "USA")
        {
            _total = _total + 35;
        }
        Console.Write(_total);
        Console.WriteLine(". $35 Dollars were added on if outside USA.");
        Console.WriteLine("\nPacking Label:");
        product.DisplayAll();
        product1.DisplayAll();
        product2.DisplayAll();
        Console.WriteLine("\nShipping Label:");
        customer.DisplayAll();
        address.DisplayAll();
    }

}
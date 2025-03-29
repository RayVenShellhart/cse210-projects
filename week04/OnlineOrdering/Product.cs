using Microsoft.VisualBasic;

public class Product
{
    private List<string> _products = new List<string>();

    private string _productID;
    private string _name;
    private int _price;
    private int _quantity;

    private int _subTotal;

    public Product(string productID, int quantity)
    {
        _productID = productID;
        _quantity = quantity;
        _products.Add("1234, Pineapple, 5");
        _products.Add("5678, Apple, 2");
        _products.Add("9012, Fish, 20");
        _products.Add("3456, Wood-Planks, 45");
        _products.Add("7890, Flower-Pots, 35");
    }

    public string GetProduct()
    {
        foreach (string item in _products)
        {

            string[] parts = item.Split(",");
            string ID = parts[0];
            string name = parts[1];
            string price = parts[2];

            if (_productID == ID)
            {
                _name = name;
                _price = int.Parse(price);
                _subTotal = _price * _quantity;
            }

        }
        return $"{_subTotal}";

    }

    public void DisplayAll()
    {
        foreach (string item in _products)
        {
            string[] parts = item.Split(", ");
            string ID = parts[0];
            string name = parts[1];
            string price = parts[2];
            if (_productID == ID)
            {
                _price = int.Parse(price);
                _name = name;
                Console.WriteLine($"    ${_price} per {_name}. Ordered {_quantity}. ProductID: {_productID}");
            }

        }
    }
}

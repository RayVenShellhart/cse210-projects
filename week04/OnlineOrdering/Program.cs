using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Order order = new Order();
        Product product = new Product("1234", 3);
        Product product1 = new Product("5678", 2);
        Customer customer = new Customer("Phill");
        Address address = new Address("14 ave", "Oakland", "California", "USA");
        order.DisplayAll(product, product1, customer, address);

        Order order1 = new Order();
        Product product2 = new Product("9012", 2);
        Product product3 = new Product("3456", 1);
        Customer customer1 = new Customer("Dave");
        Address address1 = new Address("Via della Poiveriera", "Civitavecchia", "Rome", "Italy");
        order1.DisplayAll(product2, product3, customer1, address1);

        Order order2 = new Order();
        Product product4 = new Product("1234", 4);
        Product product5 = new Product("3456", 2);
        Product product6 = new Product("9012", 1);
        Address address2 = new Address("Hoffman Road", "Olympa", "Washigton", "USA");
        Customer customer2 = new Customer("Matt");
        order2.DisplayAllLarge(product4, product5, product6, customer2, address2);


    }
}
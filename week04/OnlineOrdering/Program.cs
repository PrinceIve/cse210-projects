using System;
using System.Collections.Generic;

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string cityName, string stateName, string countryName)
    {
        street = streetAddress;
        city = cityName;
        state = stateName;
        country = countryName;
    }

    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return street + "\n" + city + ", " + state + "\n" + country;
    }
}

class Customer
{
    private string name;
    private Address address;

    public Customer(string customerName, Address customerAddress)
    {
        name = customerName;
        address = customerAddress;
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    public string GetName()
    {
        return name;
    }

    public string GetAddress()
    {
        return address.GetFullAddress();
    }
}

class Product
{
    private string productName;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string id, double unitPrice, int qty)
    {
        productName = name;
        productId = id;
        price = unitPrice;
        quantity = qty;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetPackingLabel()
    {
        return productName + " (" + productId + ")";
    }
}

class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer orderCustomer)
    {
        customer = orderCustomer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        total += customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping To:\n" + customer.GetName() + "\n" + customer.GetAddress();
    }
}

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 50, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "P2001", 500, 1));
        order2.AddProduct(new Product("Keyboard", "P2002", 80, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        //Creates the first Order
        Order order1 = new Order();

        //Creating a costumer and its address
        Address address1 = new Address("Main Street", "Orlando", "Florida", "United States");
        Costumer costumer1 = new Costumer("Polly Jones", address1);

        //Setting the variable costumer of the first order
        order1.SetCostumer(costumer1);

        //Creating products for the first order:
        //Product 1:
        Product product1 = new Product("Headphones", 101, 8.99, 1);
        //Product 2:
        Product product2 = new Product("Laptop", 234, 299.99, 3);
        //Product 3:
        Product product3 = new Product("Web Cam", 345, 64.50, 2);

        //Adding products to a list inside of the first order
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        //Creates the second Order
        Order order2 = new Order();

        //Creating a costumer and its address
        Address address2 = new Address("Ave. Banzer", "Santa Cruz de la Sierra", "Santa Cruz", "Bolivia");
        Costumer costumer2 = new Costumer("Maria Toledo", address2);

        //Setting the variable costumer of the first order
        order2.SetCostumer(costumer2);
        
        //Creating products for the second order:
        //Product 4:
        Product product4 = new Product("Computer Graphics Card", 123, 119.58, 3);
        //Product 5:
        Product product5 = new Product("Keyboard", 785, 27.99, 3);
        //Product 6:
        Product product6 = new Product("Computer Speaker", 404, 21.95, 2);

        //Adding products to a list inside of the second order
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        //Calling the methods to get the packing label, the shipping label, 
        //and the total price of the first order, and display them.
        Console.WriteLine("Order One:");
        Console.WriteLine($"Packing label: {order1.ReturnPackingLabel()}");
        Console.WriteLine($"Shipping label: {order1.ReturnShippingLabel()}");
        Console.WriteLine($"Total cost: {order1.GetTotalCost()}");

        Console.WriteLine("");

        //Second order.
        Console.WriteLine("Order Two:");
        Console.WriteLine($"Packing label: {order2.ReturnPackingLabel()}");
        Console.WriteLine($"Shipping label: {order2.ReturnShippingLabel()}");
        Console.WriteLine($"Total cost: {order2.GetTotalCost()}");
    }
}
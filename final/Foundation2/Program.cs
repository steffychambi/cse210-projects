using System;

class Program
{
    static void Main(string[] args)
    {
        //Creates the first Order
        Order order1 = new Order();

        //Creating a costumer and its address
        Address address1 = new Address("Main Street", "Orlando", "Florida", "United States");
        Customer customer1 = new Customer("Polly Jones", address1);

        //Setting the variable costumer of the first order
        order1.SetCustomer(customer1);

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
        Customer customer2 = new Customer("Maria Toledo", address2);

        //Setting the variable costumer of the first order
        order2.SetCustomer(customer2);
        
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

        Console.Clear();

        //Calling the methods to get the packing label, the shipping label and displaying them. 
        Console.WriteLine("Order One\n\r");
        Console.WriteLine($"Packing label");
        Console.WriteLine($"{order1.ReturnPackingLabel()}");
        Console.WriteLine($"Shipping label");
        Console.WriteLine($"{order1.ReturnShippingLabel()}");

        //Calculating the total cost and displaying it.
        order1.CalculateShippingCost();
        order1.CalculateTotalCost();
        Console.WriteLine($"Total cost: {order1.GetTotalCost()} $");

        Console.WriteLine("");

        //Second order.
        Console.WriteLine("Order Two\n\r");
        Console.WriteLine($"Packing label");
        Console.WriteLine($"{order2.ReturnPackingLabel()}");
        Console.WriteLine($"Shipping label");
        Console.WriteLine($"{order2.ReturnShippingLabel()}");

        //Calculating the total cost and displaying it.
        order2.CalculateShippingCost();
        order2.CalculateTotalCost();
        Console.WriteLine($"Total cost: {order2.GetTotalCost()} $");
    }
}
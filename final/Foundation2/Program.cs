using System;

class Program
{
    static void Main(string[] args)
    {

        Address a1 = new Address("7021 Hearst Dr", "El Dorado Hills", "CA", "USA");
        Customer c1 = new Customer("Elly Evans", a1);
        Order order1 = new Order(c1);
        order1.AddProduct(new Product("Digital Camera", "P101", 199.99, 1));
        order1.AddProduct(new Product("Jacket", "P102", 30.50, 2));

      
        Address a2 = new Address("4210 Hawk View Rd", "London", "England", "UK");
        Customer c2 = new Customer("Howie Martin", a2);
        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Whopper", "P201", 6.00, 55));
        order2.AddProduct(new Product("French Fry Plush", "P202", 10.99, 55));
        order2.AddProduct(new Product("HDMI Cable", "P203", 10.00, 3));

        List<Order> hmorders = new List<Order> { order1, order2 };

        foreach (Order hmorder in hmorders)
        {
            Console.WriteLine(hmorder.GetPackingLabel());
            Console.WriteLine(hmorder.GetShippingLabel());
            Console.WriteLine($"Total Price: ${hmorder.GetTotalPrice().ToString("0.00")}\n\n");            
        }
    }    
}
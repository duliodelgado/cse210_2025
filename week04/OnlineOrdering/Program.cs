// Program.cs – crea dos pedidos y muestra etiquetas + total
// Autor: Dulio Delgado

using System;                   // << TODOS los using al inicio
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ---------- Pedido 1 ----------
        Address addr1 = new Address("123 Elm St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Alice Smith", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("T-Shirt",  "TS001", 15.00, 2));
        order1.AddProduct(new Product("Mug",      "MG123",  7.50, 3));

        // ---------- Pedido 2 ----------
        Address addr2 = new Address("456 Pine Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Bob Johnson", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Notebook", "NB007", 4.25, 5));
        order2.AddProduct(new Product("Pen Set",  "PN002", 6.99, 1));

        // Lista de pedidos
        List<Order> orders = new List<Order> { order1, order2 };

        int idx = 1;
        foreach (Order o in orders)
        {
            Console.WriteLine($"--- Order {idx} ---");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine($"Total Price: $ {o.GetTotalCost():0.00}\n");
            idx++;
        }

        Console.WriteLine("Program finished. Press any key to exit.");
        Console.ReadKey();
    }
}
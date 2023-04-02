using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Milk", 00001, 29, 2);
        Address address = new Address("440 west","Rexburg","Idaho","US");
        Customer customer = new Customer("Jhon",address);
        Order order = new Order(customer);





        Console.WriteLine("Hello Foundation2 World!");
    }
}
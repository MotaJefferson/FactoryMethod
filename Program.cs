using System;
using PizzariaFactoryMethod.Creators;

class Program
{
    static void Main(string[] args)
    {
        var margheritaCreator = new MargheritaPizzaCreator();
        Console.WriteLine("---- Pedido: Pizza Margherita ----");
        margheritaCreator.FazerPizza();

        var pepperoniCreator = new PepperoniPizzaCreator();
        Console.WriteLine("\n---- Pedido: Pizza Pepperoni ----");
        pepperoniCreator.FazerPizza();

        var portuguesaCreator = new PortuguesaPizzaCreator();
        Console.WriteLine("\n---- Pedido: Pizza Portuguesa ----");
        portuguesaCreator.FazerPizza();
    }
}

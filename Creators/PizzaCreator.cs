using PizzariaFactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaFactoryMethod.Creators
{
    public abstract class PizzaCreator
    {
        public abstract IPizza CriarPizza();

        public void FazerPizza()
        {
            var pizza = CriarPizza();
            pizza.Preparar();
            Console.WriteLine("Pizza está pronta para ser assada no forno!");
        }
    }
}

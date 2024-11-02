using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaFactoryMethod.Products
{
    public class PizzaPortuguesa : IPizza
    {
        public void Preparar()
        {
            Console.WriteLine("Preparando Pizza Portuguesa: molho de tomate, mussarela, presunto, ovos e cebola.");
        }
    }
}

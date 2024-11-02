using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaFactoryMethod.Products
{
    public class PizzaPepperoni : IPizza
    {
        public void Preparar()
        {
            Console.WriteLine("Preparando Pizza Pepperoni: molho de tomate, mussarela e pepperoni.");
        }
    }
}

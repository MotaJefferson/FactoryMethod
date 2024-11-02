using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaFactoryMethod.Products
{
    public class PizzaMargherita : IPizza
    {
        public void Preparar()
        {
            Console.WriteLine("Preparando Pizza Margherita: molho de tomate, mussarela e manjericão.");
        }
    }
}

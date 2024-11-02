using PizzariaFactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaFactoryMethod.Creators
{
    public class MargheritaPizzaCreator : PizzaCreator
    {
        public override IPizza CriarPizza()
        {
            return new PizzaMargherita();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryPat fa = new FactoryPat();
            fa.GetIngredients("Egg").Ingredients();
            fa.GetIngredients("Tomatoes").Ingredients();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class FactoryPat
    {
        public ICommunication GetIngredients(string name)
        {
            switch(name)
            {
                case "Egg": return  new Egg();
                case "Tomatoes": return new Tomatoes();
                default: return null;
            }
            return null;
        }
    }
}

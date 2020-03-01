using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListCreator.Logic;

namespace ShoppingListCreator.Objects
{
    public class Ingredient
    {
        public string Name { get; private set; }
        public double Amount { get; set; }
        public UnitType Unit { get; set; }
    }
}

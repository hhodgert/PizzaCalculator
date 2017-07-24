using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalculator
{
    public class PizzaCalculator
    {
        public static string Calculate(string peopleString)
        {
            int people;
            if (int.TryParse(peopleString, out people))
            {
                var pizzas = people / 3;
                return $"Pizzas needed {pizzas}";
            }
            return "No people entered";
        }
    }
}

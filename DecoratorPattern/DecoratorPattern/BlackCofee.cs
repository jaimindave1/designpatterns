using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class BlackCofee : Beverage
    {
        public BlackCofee()
        {
            Description = "Black Cofee";
        }

        public override double getCost()
        {
            return 50;
        }
    }
}

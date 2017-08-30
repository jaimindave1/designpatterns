using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Chocolate : CondimentDecorator
    {
        Beverage _beverage;

        public Chocolate(Beverage beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + "+ Chocolate";
        }

        public override string getDescription()
        {
            return Description;
        }

        public override double getCost()
        {
            return _beverage.getCost() + 20;
        }
    }
}

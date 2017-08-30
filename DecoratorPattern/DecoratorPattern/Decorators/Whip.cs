using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Whip : CondimentDecorator
    {
        Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + "+ Whip";
        }

        public override string getDescription()
        {
            return Description;
        }

        public override double getCost()
        {
            return _beverage.getCost() + 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Mocha : CondimentDecorator
    {
        Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + "+ Mocha";
        }

        public override string getDescription()
        {
            return Description;
        }

        public override double getCost()
        {
            return _beverage.getCost() + 10;
        }
    }
}

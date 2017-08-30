﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class LemonTea : Beverage
    {
        public LemonTea()
        {
            Description = "Lemon Tea";
        }

        public override double getCost()
        {
            return 60;
        }
    }
}

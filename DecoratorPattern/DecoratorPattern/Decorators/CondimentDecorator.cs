﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class CondimentDecorator : Beverage
    {
        public abstract string getDescription();
    }
}

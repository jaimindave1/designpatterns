using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Services
{
    public class TravelByBus : ITravelStragy
    {
        public void TravelBy(string employeeName)
        {
            Console.WriteLine(employeeName + " Will take Bus.");
        }
    }
}

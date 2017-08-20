using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Services
{
    public class TravelByTrain : ITravelStragy
    {
        public void TravelBy(string employeeName)
        {
            Console.WriteLine(employeeName + " Will take Train.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Services
{
    public class TravelByPlane : ITravelStragy
    {
        public void TravelBy(string employeeName)
        {
            Console.WriteLine(employeeName + " Will take Plane.");
        }
    }
}

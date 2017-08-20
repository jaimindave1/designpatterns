using StrategyPattern;
using StrategyPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ITravelStragy travelStrategy = null;

            List<EmplyoyeeDetails> employeeList = EmplyoyeeDetails.BindEmployeeList();

            foreach (var employee in employeeList)
            {
                travelStrategy = GetTravelStrategy(employee);
                travelStrategy.TravelBy(employee.EmployeeName);
            }

            Console.ReadLine();
        }

        private static ITravelStragy GetTravelStrategy(EmplyoyeeDetails employeeDetails)
        {
            ITravelStragy travelstrategy = null;

            switch (employeeDetails.Designation)
            {
                case Global.Designation.JuniorDeveloper:
                    return new TravelByTrain();
                case Global.Designation.SeniorDeveloper:
                    return new TravelByBus();
                case Global.Designation.ProjectManager:
                    return new TravelByPlane();
            }

            return travelstrategy;
        }
    }
}

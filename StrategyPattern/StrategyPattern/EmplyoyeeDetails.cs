using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class EmplyoyeeDetails
    {
        public EmplyoyeeDetails(string name, StrategyPattern.Global.Designation designation)
        {
            EmployeeName = name;
            Designation = designation;
        }
        public string EmployeeName { get; set; }
        public StrategyPattern.Global.Designation Designation { get; set; }

        public static List<EmplyoyeeDetails> BindEmployeeList()
        {
            var employeeDetails = new List<EmplyoyeeDetails>();

            employeeDetails.Add(new EmplyoyeeDetails("Jaimin", Global.Designation.ProjectManager));
            employeeDetails.Add(new EmplyoyeeDetails("James", Global.Designation.SeniorDeveloper));
            employeeDetails.Add(new EmplyoyeeDetails("Ana", Global.Designation.ProjectManager));
            employeeDetails.Add(new EmplyoyeeDetails("Jeremy", Global.Designation.JuniorDeveloper));

            return employeeDetails;
        }
    }
}

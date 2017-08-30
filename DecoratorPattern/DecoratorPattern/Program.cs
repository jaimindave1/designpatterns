using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Black coffee with double whip mocha
            Beverage cofee = new BlackCofee();
            cofee = new Mocha(new Whip(new Whip(cofee)));
            Console.WriteLine(cofee.getDescription());
            Console.WriteLine(cofee.getCost());

            //Espresso with mocha
            Beverage espresso = new Mocha(new Espresso());
            Console.WriteLine(espresso.getDescription());
            Console.WriteLine(espresso.getCost());

            //Lemon tea
            Beverage lemonTea = new LemonTea();
            Console.WriteLine(lemonTea.getDescription());
            Console.WriteLine(lemonTea.getCost());

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton01
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.GetInstance();
            obj.PrintMessage("Hello world");

            Singleton obj2 = Singleton.GetInstance();
            obj2.PrintMessage("Hello world");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton01
{
    public sealed class Singleton
    {
        private static int Counter = 0;
        
        private static Singleton _singletonObj= null;

        public static Singleton GetInstance()
        {
            if (_singletonObj == null)
                _singletonObj = new Singleton();
            return _singletonObj;
        }

        private Singleton()
        {   
            Counter++;
        }

        public void PrintMessage(string message) 
        {
            Console.WriteLine(message + " Object " + Counter);
        }
    }
}

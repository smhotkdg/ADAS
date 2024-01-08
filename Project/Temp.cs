using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    class Temp
    {
        static public Temp Singleton
        {
            get;
            private set;
        }

        static Temp()
        {
            Singleton = new Temp();
        }       
  
        static double Distance = 0;
        static string Warring = string.Empty;
        static string Speed = string.Empty;
        static string Caution = string.Empty;
    }
}

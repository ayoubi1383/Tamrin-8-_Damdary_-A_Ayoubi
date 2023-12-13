using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tamrin__8__Damdary__A_Ayoubi
{
    public abstract class Animal
    {
        public double Weight { get; set; }
        public bool IsMaile { get; set; }
        public DateTime BirthDate { get; set; }
        public abstract int Life();
        public abstract double  StressFactor();
        public abstract int TimeToDie();
        public double KillPriority()
        {
            for (int i = 0; i < Life(); i++)
            {
                return 0;
            }
            return 1;
        }
        

    }
    public class CCounter
    {

        static CCounter()
        {
            Counter = 0;
        }
        public CCounter()
        {
            Counter++;
            Number = Counter;
        }

        public static int Counter { get; private set; }
        public int Number { get; }
    }
}


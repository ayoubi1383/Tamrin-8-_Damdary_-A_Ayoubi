using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Tamrin__8__Damdary__A_Ayoubi
{
    class Cow : Animal
    {
        static Cow() { MaxLife = 9325; }
        public static int MaxLife { get; private set; }

        public override int Life()
        {
            return MaxLife;
        }
        public override int TimeToDie()
        {
            int Age = (int)(DateTime.Now - BirthDate).TotalDays;
            return MaxLife - Age;
        }
        public override double  StressFactor()
        {
            Environment stress  = new Environment();
            double Result = (stress.TDS + stress.Temp + stress.Density + stress.db + stress.AQL +
                stress.OX) / 6;
            return Result ;
        }

    }
}


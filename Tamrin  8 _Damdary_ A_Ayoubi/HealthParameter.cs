using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin__8__Damdary__A_Ayoubi
{
     class HealthParameter<T> 
    {
        public string Name { get; set; }
        public T Current { get; set; }
        public T Standard { get; set; }
        public double  Alfa {  get; set; }
        public double StressFactor() =>
            ((Convert.ToDouble(Current) / Convert.ToDouble(Standard)) + Alfa) * 100;

    }
}

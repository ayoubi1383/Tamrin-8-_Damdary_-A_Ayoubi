using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin__8__Damdary__A_Ayoubi
{
    class CowParameter<T>
    {
        private int _TimeToStand { get; set; }
        public int TimeToStand 
        {
            get => _TimeToStand;
            set
            {
                //HealthParameter<double> hp = new HealthParameter<double>();
                //_TimeToStand = 4;
                //hp.Alfa = 0.2;
                //_TimeToStand  = (int)(_TimeToStand * hp.Alfa);
                //return _TimeToStand;
                
            }
        }
        public int TimeToRelax { get; set; }
        public int NumberOfMeal { get; set; }
        public int TimeToDeal { get; set; }
        public int NumberOfMilkProduction  { get; set; }


    }
}

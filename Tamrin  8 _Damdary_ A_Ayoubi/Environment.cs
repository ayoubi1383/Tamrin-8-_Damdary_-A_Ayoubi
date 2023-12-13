using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin__8__Damdary__A_Ayoubi
{
    class Environment : HealthParameter<T>
    {
        private double _tds { get; set; }
        public double  TDS 
        {
            get => _tds ;
            set
            {
                Current = 750;
                Standard = 5000;
                Alfa = 0.2;
                _tds = StressFactor();
            }
        }
        private double  _temp { get; set; }
        public double  Temp 
        {
            get => _temp; 
            set
            {
                Current = 25;
                Standard = 26;
                Alfa = 0.1;
                _temp = StressFactor();

            }
        }
        private double  _density { get; set; }
        public double  Density 
        {
            get => _density;
            set
            {
                Current = 25;
                Standard = 26;
                Alfa = 0.1;
                _density = StressFactor();
            }
        }
        private double _db { get; set; }
        public double  db 
        {
            get => _db;
            set
            {
                Current = 25;
                Standard = 26;
                Alfa = 0.1;
                _db = StressFactor();
            }
        }
        private double _aql { get; set; }
        public double  AQL 
        {
            get => _aql;
            set
            {
                Current = 25;
                Standard = 26;
                Alfa = 0.1;
                _db = StressFactor();
            }
        }
        private double _ox { get; set; }
        public double  OX 
        {
            get => _ox;
            set
            {
                Current = 25;
                Standard = 26;
                Alfa = 0.1;
                _db = StressFactor();
            } 
        }
        
    }
}

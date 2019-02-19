﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  
        public class Town
        {
            public string Name;
            public string Country;
            public string Region;
            public int Population;
            public double YearIncome;
            public double Square; public bool HasPort;
            public bool HasAirport;
            public double GetYearIncomePerInhabitant()
            { return YearIncome / Population; }
        }
    
}

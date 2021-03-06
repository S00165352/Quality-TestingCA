﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using fit.Fixtures;

namespace TestingCA
{
    public class CalcPrem
    {
        public Double CalcPremium(int age, string gender)
        {
            double premium;

            gender.ToLower();

            if (gender == "female")
                if ((age >= 18) && (age <= 30))
                    premium = 5.0;
                else if (age >= 31)
                    premium = 3.50;
                else
                    premium = 0.0;
            else if (gender == "male")
                if ((age >= 18) && (age <= 35))
                    premium = 6.0;
                else if (age >= 36)
                    premium = 5.0;
                else
                    premium = 0.0;
            else
                premium = 0.0;

            if (age >= 50)
                premium = premium * 0.5;
            return premium;
        }
    }
      

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AlexandrovaEA.Sprint2.Task4.V20.Lib
{
    public class DataService : ISprint2Task4V20
    {
        public double Calculate(double x, double y)
        {
            double z;
            z = (x + 10) > (y * x) ? z = (x * Math.Pow(((y + 1) / (x - 1)), x)) : z = Math.Pow(x, 2) - (1 / y);

            return Math.Round(z, 3);
        }
    }
}

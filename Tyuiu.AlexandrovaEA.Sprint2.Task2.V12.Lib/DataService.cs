﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AlexandrovaEA.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool t;
            if (((x >= 3 && x <= 5) && (y >= 3 && y <= 7)) || ((x >= 9 && x <= 12) && (y >= 3 && y <= 8)) || ((x >= 6 && x <= 8) && (y >= 5 && y <= 8))
                || ((x == 13) && (y >= 6 && y <= 8)) || ((x >= 11 && x <= 12) && (y >= 9 && y <= 12)) || ((y == 11) && (x >= 3 && x <= 7)) || (x == 7 && y == 12)
                || ((x >= 6 && x <= 7) && (y >= 9 && y <= 10)))
            {
                t = true;
            }
            else t = false;
            return t;
        }
    }
}

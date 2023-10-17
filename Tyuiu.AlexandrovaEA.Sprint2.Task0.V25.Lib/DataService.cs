using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
//x=205,y=159 ==, !=, <, >, <=, >=, True, True, True, False, False, False
namespace Tyuiu.AlexandrovaEA.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x - 46 == y;
            res[1] = x != y;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = x <= y;
            res[5] = y >= x;
            return res;
        }
    }
}

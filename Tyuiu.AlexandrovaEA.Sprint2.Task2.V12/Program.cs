using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AlexandrovaEA.Sprint2.Task2.V12.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint2.Task2.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            bool res;
            Console.Title = "Спринт #2 | Выполнил: Александрова Е. А. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: АЛГОРИТМЫ РАЗВЕТВЛЯЮЩЕЙСЯ СТРУКТУРЫ                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Александрова Е. А. | ИСПБ-23-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и*");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной        *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("X = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckDotInShadedArea(x, y))
            {
                Console.WriteLine("точка с координатами " + x + ", " + y + " находится в заштрихованной области");
            }else Console.WriteLine("точка с координатами " + x + ", " + y + " не находится в заштрихованной области");

            Console.ReadKey();
        }
    }
}

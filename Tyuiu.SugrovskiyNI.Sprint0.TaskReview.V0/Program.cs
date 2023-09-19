using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNum = 3;
            int SecondNum = 4;
            int ThirdNum = 5;

            int result = DataService.Clac(FirstNum, SecondNum, ThirdNum);

            Console.WriteLine($"Значение выражения ({FirstNum} + {SecondNum} + {ThirdNum}) * 5 = {result}");
            Console.ReadKey();
        }
    }
}

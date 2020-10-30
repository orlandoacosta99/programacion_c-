using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLinq
{
    public static class TestFunc
    {


        public static void Test(Func<string, string, int> fn)
        {

            int number = fn("hola", "adios");

        }


        public static Func<int, int, int> SumTwoNumbers = 
            
        (number1, number2) =>
        {
            return number1 + number2;
        };


    }
}

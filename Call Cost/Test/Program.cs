using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ChatAWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calculated variables to output cost of call based on area code and duration of call

            int[] areaCode = { 262, 414, 608, 715, 815, 920 };
            double[] rate = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };



            Write("Please enter your area code: ");
            int inputArea = Convert.ToInt32(ReadLine());

            Write("How many minutes will this call be? ");
            double callMins = Convert.ToDouble(ReadLine());


            for (int i = 0; i < areaCode.Length; i++)
            {
                if (inputArea == areaCode[i])
                {
                    double total = callMins * rate[i];
                    WriteLine("The cost of this call will be " + total.ToString("C") + ".");
                };

            }

            ReadKey();


        }
    }
}
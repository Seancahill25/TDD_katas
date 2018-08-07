using System;

namespace String_Calculator
{
    public class StringCalculator
    {
        public static int Calculate(string equation)
        {
            if (equation == "")
            {
                return 0;
            }

            string[] array = equation.Split(",");
            int[] intArray = new int[array.Length];

            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(array[i]);
            }


            if (intArray.Length == 1)
            {
                return Convert.ToInt32(equation);
            }
            else
            {
                return intArray[0] + intArray[1];
            }

        }
    }
}
namespace Partial_Task2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    static class Sqrt
    {
        private static double number;
        // formula Gerona 
        public static double getSqrt(double number)
        {
            Sqrt.number = number;
            double answer = 0.0;
            double limit = 3.0;

            for (int i = 1; i <= 1000; ++i)
            {
                answer = (limit + (number / limit)) / 2.0;

                double diff = (answer - limit) - 1.0;
                if (diff == -1.0 || diff == 1.0)
                {
                    break;
                }
                limit = answer;
            }
            return answer;
        }
    }
}

using System;

namespace exam
{
    class program
    {
        static void Main(string[] args)
        {
            debugAndTrace.onStart();
            year(Convert.ToDouble(Console.ReadLine()));
        }

        static void year(double N)
        {
            int monthCount = 1;
            double percent = getPercent(N);
            for (int i = 0; i < 12; i++)
            {
                if (monthCount == 3)
                {
                    percent = percent + 0.5;
                    monthCount = 0;
                }
                monthCount++;
            }
        }

        static double getPercent(double N)
        {
            int a;
            if(N < 700000)
            {
                a = Convert.ToInt32(Math.Floor(N / 50000.0)) + 1;
            }
            else
            {

            }
            return a;
        }
    }
}
/*
0-50 1
50-100 2
100-150 3
150-200 4
200-250 5
250-300 6
300-350 7
350-400 8
400-450 9
450-500 10
500-550 11
550-600 12
600-650 13
650-700 14
 */
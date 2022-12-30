    using System;
namespace PERFECT_NUMB_2
{
    internal class PerfectNumb

    {
        static void Main()
        {
            Console.WriteLine("" /***** program - Perfect Numbers From 1 to 100 *****/ );
            int number, sum0fNumbers = 0, i = 1;
            Console.WriteLine("Perfect Numbers From 1 to 100 are: ");
            for (number = 1; number <= 100; number++)
            {
                i = 1;
                sum0fNumbers = 0;
                while (i < number)
                {
                    if (number % i == 0)
                        sum0fNumbers =
                         sum0fNumbers + i;
                    i++;
                }
                if (sum0fNumbers == number)
                {
                    Console.WriteLine("{0} is a Perfect Number", number);
                }
            }
            Console.ReadLine();

        }
    }
}

using System;

namespace _10_25_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //yaz = 3 4 5
            //yay = 6 7 8
            //payis = 9 10 11 
            // qis= 12 1 2


            #region Fesiller

            while (true)
            {
                int month = Convert.ToInt32(Console.ReadLine());
                if (0 < month && 12 >= month)
                {
                    if (month >= 3 && month <= 5)
                    {
                        Console.WriteLine("yaz fesilidi");
                    }
                    else if (month >= 6 && month <= 8)
                    {
                        Console.WriteLine("yay fesilidi");
                    }
                    else if (month >= 9 && month <= 11)
                    {
                        Console.WriteLine("payiz fesilidi");
                    }
                    else
                    {
                        Console.WriteLine("qis fesilidi");
                    }
                }
                else
                {
                    Console.WriteLine("Bele bir ay movcud deyil");
                }
                

            }
            #endregion



        }
    }
}

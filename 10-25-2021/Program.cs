using System;

namespace _10_25_2021
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                int count = 2;
                int eded = 2;
                bool sadedimi = true;
                while (eded < input)
                {
                    if (input % eded == 0)
                    {
                        for (int i = 2; i * i <= eded; i++)
                        {
                            if (eded % i == 0)
                            {
                                sadedimi = false;

                            }

                        }

                        count++;
                    }
                    eded++;

                }
                

            }
            #region task bolenleri
            /**
             int input = Convert.ToInt32(Console.ReadLine());
            int count = 2;
            int eded = 2;
            while (eded < input)
            {
                if (input % eded == 0)
                {
                    count++;
                }
                eded++;

            }
            Console.WriteLine(count);
            **/
            #endregion



            #region Fesiller
            /**
             * 
             * //yaz - 3 4 5
            //yay - 6 7 8
            //payis - 9 10 11 
            // qis- 12 1 2
            
             * 
             * 
            while (true)
            {
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (0 < month && 12 >= month)
                    {
                        if (month >= 3 && month <= 5)
                        {
                            Console.WriteLine("yaz fesilidi");
                            break;
                        }
                        else if (month >= 6 && month <= 8)
                        {
                            Console.WriteLine("yay fesilidi");
                            break;
                        }
                        else if (month >= 9 && month <= 11)
                        {
                            Console.WriteLine("payiz fesilidi");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("qis fesilidi");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bele bir ay movcud deyil");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("duzgun formatda daxil edin");
                }
            }
            **/
            #endregion
        }
    }
}

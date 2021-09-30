using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //int correctNumber = random.Next(1, 10);
            //int guess = 0;
           // Console.WriteLine("Guess number between 1-10 ;)");

          //  while (guess != correctNumber)
            {
               // string input = Console.ReadLine();
               // if (!int.TryParse(input, out guess))
                 //   Console.WriteLine("Please write A Fukin Number Mate!!");



              //  if (guess != correctNumber)
                {
                   // Console.WriteLine("Wrong Number, try again");

                }

            }
            Random random = new Random();
            int correctNumber = random.Next(1, 10);
           // Console.WriteLine("You have won");
           
                bool loopactive = true;
            while (loopactive)
            {
                Console.WriteLine("Vali nmber 1- 10");
                int userName = Convert.ToInt32(Console.ReadLine());

                if(cpuRandom == userNumber)
                {
                    Console.WriteLine("Paljuõnne oled võitnud emili endale");

                }    





            }


        }



    }
} 


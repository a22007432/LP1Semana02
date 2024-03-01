using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer,n ;
            bool correct = false;
            bool validn = false;
            int cases;
            int lim = 0;


            

            do
            { 


                Console.WriteLine("Number Master insert number: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0 || n > 100)
                {
                    Console.WriteLine("invalid number try again");

                }
                else
                {
                    validn = true;
                    while (lim<100)
                    {
                        Console.WriteLine("");
                        ++lim;
                    }
                }

            }while(validn == false);

                
            do
            {
                Console.WriteLine("Player insert number: ");
                answer = int.Parse(Console.ReadLine());
                if (answer < 0 ||  answer > 100)
                {
                    Console.WriteLine("invalid number try again");

                }

                if(answer>n)
                {
                    Console.WriteLine($"The correct num is smaller than {answer}");
                }
                if(answer<n)
                {
                    Console.WriteLine($"The correct num is larger than {answer}");
                }
                else
                {
                    correct = true;
                }
                


            } while(correct == false);
            Console.WriteLine($"Player wins!");
        }
    }
}

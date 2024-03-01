using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            bool correct = false;
            bool validn = false;


            

            do
            { 


                Console.WriteLine("Number Master insert number: ");
                int n = int.Parse(Console.ReadLine());
                if (n < 0 || n > 100)
                {
                    Console.WriteLine("invalid number try again");

                }
                else
                {
                    validn = true;
                }
            }while(validn == false);


            

            /*if (n < 0 || n > 100)
            {
                Console.WriteLine("invalid number get out");
            }
            else
            {
                
                do
                {
                    if(correct == false)
                    {
                        
                    }

                } while(correct == false);
            }*/
        }
    }
}

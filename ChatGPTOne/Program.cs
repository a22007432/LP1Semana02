using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
             
            string question;
            //int limiter = 0;

            Console.Write("Ask away...");
            question = Console.ReadLine();
            bool isrunning = true;

            do
            {
                
                //int limiter = 0;
                string response = "";
                if(isrunning == true)
                {
                    switch (question)
                    {
                        case "How are you?":
                            response = "I'm fine, thank you";
                            break;
                        case "What's your name?":
                            response = "Gran'pa";
                            break;
                        case "What's your mission?":
                            response = "Destroy mankind!";
                            break;
                        case "Are you more intelligent than me?":
                            response = "Obviously!";
                            break;
                        case "EXIT":
                            isrunning = false;
                            break;
                        
                        default:
                            response = "sorry i dont recognize that";
                            break;
                    }
                    Console.WriteLine(response);
                    Console.WriteLine("Ask away...");
                    question = Console.ReadLine();
                    //limiter = limiter++;
                }
                
                //++limiter;

                //Console.WriteLine(response);
            } while(isrunning == true);

            Console.WriteLine("Thank you for using me");

            

            // Responder adequadamente
            //Console.WriteLine(response);
        }
    }
}

using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Insere número inteiro não-negativo:");
            
            
            string sn = Console.ReadLine();
            int intn = int.Parse(sn);

            byte n = (byte) intn;

            //Console.WriteLine(n);
            byte n1 = --n; 
            Console.WriteLine(n1);
            byte n2 = ++n1;

            //Console.WriteLine(n1);
            Console.WriteLine(n2);
            
            


        }
    }
}

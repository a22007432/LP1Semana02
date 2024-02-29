using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Insere número inteiro não-negativo:");
            
            
            string sn = Console.ReadLine();
            //int intn = int.Parse(sn);

            byte n = byte.Parse(sn);

            //Console.WriteLine(n);
            //byte n1 = --n; 
            Console.WriteLine(--n);
            Console.WriteLine(++n);
            //byte n2 = ++n1;

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);

            

            //Console.WriteLine($"this is n : ->{n}");
            Console.WriteLine((n/2));
            Console.WriteLine((n<<3));
            Console.WriteLine((n^5));
            Console.WriteLine((n>10));
            
            


        }
    }
}

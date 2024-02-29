using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert the height of a cylinder (r n):");
            float h = float.Parse(Console.ReadLine());

            Console.Write("Please insert the radius of a cylinder (r n):");
            float rad = float.Parse(Console.ReadLine());
            
            float pi = MathF.PI;
            float v = pi * MathF.Pow(rad, 2) * h;

            Console.WriteLine($"Volume: {v}");

            float s = 2*pi*rad*(rad+h);
            Console.WriteLine($"Surface Area: {s}");



            
            


            
        }
    }
}

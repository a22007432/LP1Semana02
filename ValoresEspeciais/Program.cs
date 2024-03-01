using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            int i_s = int.MinValue;

            float f = float.MaxValue;
            float f_s = float.MinValue;

            double d = double.MaxValue;
            double d_s = double.MinValue;

            byte b = byte.MaxValue;
            byte b_s = byte.MinValue;
            
            short s = short.MaxValue;
            short s_s = short.MinValue;

            Console.WriteLine(i);
            Console.WriteLine(i_s);

            Console.WriteLine(d);
            Console.WriteLine(d_s);

            Console.WriteLine(b);
            Console.WriteLine(b_s);

            Console.WriteLine(s);
            Console.WriteLine(s_s);

            Console.WriteLine(f);
            Console.WriteLine(f_s);

            double x = double.PositiveInfinity;
            double y = double.NegativeInfinity;
            double z = double.PositiveInfinity / double.NegativeInfinity;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            float xf = float.PositiveInfinity;
            float yf = float.NegativeInfinity;
            float zf = float.NaN;

            Console.WriteLine(xf);
            Console.WriteLine(yf);
            Console.WriteLine(zf);

            uint overi = uint.MaxValue;
            Console.WriteLine(( uint) ( overi + 1));

            float overf1 = float.MaxValue * 2;
            Console.WriteLine(overf1);

            float overf2 = float.MaxValue + 1;
            Console.WriteLine(overf2);
            
            float underf1;
            float underf2;
            underf1 = underf2 = 192134.0f;
            Console.WriteLine(underf1 == underf2 + 0.0001f); 
            



        }
    }
}

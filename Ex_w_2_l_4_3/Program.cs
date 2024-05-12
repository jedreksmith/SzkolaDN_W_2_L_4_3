using System;

using static System.Math;

namespace Ex_w_2_l_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, d, k;
            Console.WriteLine("Podaj pierwszy bok");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugi bok");
            b = double.Parse(Console.ReadLine());

            k = Pow(a,2) + Pow(b,2);    //d - kwadrat przekątnej

            d = Math.Sqrt(k);

            Console.WriteLine("Przekątna ma długość:  " + d);

        }
    }
}

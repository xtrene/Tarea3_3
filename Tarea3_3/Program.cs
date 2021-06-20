using System;

namespace Tarea3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 10;
            int Y = 3;
            double N=11.876;
            double M = 3.7563;

            Console.WriteLine("El valor de X es: {0}", X);
            Console.WriteLine("El valor de Y es: {0}", Y);
            Console.WriteLine("El valor de N es: {0}", N);
            Console.WriteLine("El valor de M es: {0}", M);

            Console.WriteLine("La suma de  X + Y es: {0}", X+Y);
            Console.WriteLine("La diferencia de X - Y es: {0}", X-Y);
            Console.WriteLine("El producto de X * Y es: {0}", X*Y);
            Console.WriteLine("El cociente de X/Y es: {0}", X/Y);
            Console.WriteLine("El resto de X/Y  es: {0}", X%Y);

            Console.WriteLine("La suma de N + M es: {0}", N + M);
            Console.WriteLine("La diferencia de N - M es: {0}", N - M);
            Console.WriteLine("El producto de N * M es: {0}", N * M);
            Console.WriteLine("El cociente de N/M es: {0}", N / M);
            Console.WriteLine("El resto de X/Y  es: {0}", N % M);

            Console.WriteLine("La suma de  X + N es: {0}", X + N);
            Console.WriteLine("El cociente de Y/M es: {0}", Y / M);
            Console.WriteLine("El resto de Y/M  es: {0}", Y % M);

            Console.WriteLine("El doble de X es: {0} ", X * 2);
            Console.WriteLine("El doble de Y es: {0} ", Y * 2);
            Console.WriteLine("El doble de N es: {0} ", N * 2);
            Console.WriteLine("El doble de M es: {0} ", M * 2);

            Console.WriteLine("La suma de todas las variables es: {0}", X + Y + N + M);
            Console.WriteLine("El producto de todas las variables es: {0}: ", X * Y * N * M);



            Console.ReadKey();
        }
    }
}

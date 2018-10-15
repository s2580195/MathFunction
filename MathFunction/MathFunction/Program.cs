using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MathFunction
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Matrix a = new Matrix(new float[,]
            {
                {1,3},
                {2,4}
            });
            
            Matrix b = new Matrix(new float[,]
            {
                {-1,5},
                {0,2}
            });

            var c = Matrix.Multiple(a, b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            Console.WriteLine("Escriba cinco números: ");
            for (int i=0; i<5; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Números: ");
            for (int i=4; i>=0; i--)
            {
                Console.Write($"\t{numbers[i]}");
            }
        }
    }
}

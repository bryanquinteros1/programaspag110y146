using System;

namespace numero_par_o_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite un numero porfavor:");

            double num = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.Write("el numero es par");
            else
                Console.Write("el numero es impar");

            Console.ReadKey();
            
        }
    }
}

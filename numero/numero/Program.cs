using System;

namespace numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, r, limite, i, auxiliar;
            Console.WriteLine(" un numero");
            limite = int.Parse(Console.ReadLine());
            a = 0;
            r = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = r;
                r = auxiliar + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}

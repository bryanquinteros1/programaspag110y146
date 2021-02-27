using System;

namespace impuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            string opciones;
            int total;
            int p;
           


            Console.WriteLine("que tipo de prodcuto es:  1-medicinal o 2-otro");
            opciones = Console.ReadLine();

            switch (opciones)
            {
                case "1":
                    Console.WriteLine("---medicinal--");

                    Console.WriteLine("ingrese el precio del producto:");
                    p = Convert.ToInt32(Console.ReadLine());



                    total = p ;

                    Console.WriteLine("no existe impuesto para este producto:" + total);

                    break;

                case "2":
                    Console.WriteLine("---otro---");


                    Console.WriteLine("ingrese el precio del producto:");
                    p = Convert.ToInt32(Console.ReadLine());


                    total = (int)(p / 1.12);

                    Console.WriteLine("el precio del producto sin impuesto:" + total);





                    break;












            }
        }
    }
}
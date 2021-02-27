using System;

namespace de_grados_a_radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            string opciones;
            int total;
            int r;
            int g;



            Console.WriteLine("que tipo de prodcuto es:  1=grados a radiales o 2=radiales a grados");
            opciones = Console.ReadLine();

            switch (opciones)
            {
                case "1":
                    Console.WriteLine("");

                    Console.WriteLine("ingrese grados:");
                    g = Convert.ToInt32(Console.ReadLine());



                    total =  ((int)(g *3.1416/180));

                    Console.WriteLine("el total de  radiales son:" + total);

                    break;

                case "2":
                    Console.WriteLine("");


                    Console.WriteLine("ingrese radiales:");
                    r = Convert.ToInt32(Console.ReadLine());


                    total = (int)(r * 180 / 3.1416);

                    Console.WriteLine("el totla de grados son:" + total);





                    break;




            }
        }
    }
}
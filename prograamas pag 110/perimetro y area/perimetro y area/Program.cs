using System;

namespace perimetro_y_area
{
    class Program
    {
        static void Main(string[] args)
        {
            string opciones;
            int lados;
            int medida;
            int b;
            int h;
            int area;
            int perimetro;


            Console.WriteLine("que desea hacer, perimetro o area?:");
            opciones = Console.ReadLine();

            switch (opciones)
            {
                case "perimetro":
                    Console.WriteLine("---perimetro---");

                    Console.WriteLine("ingrese lados de su figura:");
                    lados = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ingrese la medida del lado");
                    medida = Convert.ToInt32(Console.ReadLine());


                    perimetro = lados * medida;

                    Console.WriteLine("el perimetro de la figura es:" + perimetro);

                    break;

                case "area":
                    Console.WriteLine("---area---");

                   
                     Console.WriteLine("ingrese la base :");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ingrese la altura");
                    h = Convert.ToInt32(Console.ReadLine());


                    area = (b * h)/2;

                    Console.WriteLine("el perimetro de la figura es:" + area);



                

                    break;

            }
        }
    }
}
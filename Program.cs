using System;
using System.Globalization;



namespace curso_C_Sharp_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;
            X = new Triangulo();
            Y = new Triangulo();

            double areaX, areaY;

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = X.calculaArea();
            areaY = Y.calculaArea();

            Console.WriteLine("AREA DO TRIANGULO X : " + areaX.ToString("F4"),CultureInfo.InvariantCulture);
            Console.WriteLine("AREA DO TRIANGULO Y : " + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA:  X ");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA:  Y ");
            }
            else
            {
                Console.WriteLine("AREAS IGUAIS ");

            }



        }
    }
}


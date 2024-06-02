using System;
using System.Globalization;
using Triangulo_C_;

namespace Programa
{
    public class Programa
    {
        static void Main(string []args){
            
            Triangulo x,y;
            x = new Triangulo();
            y = new Triangulo();

                Console.WriteLine("Diga as medidas do triângulo X: ");

                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Diga as medidas do triângulo Y: ");
                y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    
                double AreaX = x.Area();
                double AreaY = y.Area();
                
                Console.WriteLine("ÁREA DE X = " + AreaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("ÁREA DE Y = " + AreaY.ToString("F4", CultureInfo.InvariantCulture));
}
    }
}

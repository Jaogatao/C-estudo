using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Geometria_Círculo
{
    class Program
    {

        static double Pi = 3.14;    
        static void Main (string[] args)
        {
            Console.Write("Entre com o valor do Raio: ");
            double Raio = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            
            double circ = Circunferencia(Raio);
            double volume = Volume(Raio);
            
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture)); 
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + Pi.ToString("F2",CultureInfo.InvariantCulture));

        }
        
        static double Circunferencia(double r){
            return 2.0 * Pi * r;

        }
        static double Volume(double r){
            return 4.0/ 3.0 * Pi * Math.Pow(r,3.0);
        }
        }
    }

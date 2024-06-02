using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos_C_
{
    class Program
    {
        static void Main (string[] args){
            Console.WriteLine("Diga os números: ");

            int n1  = int.Parse(Console.ReadLine());
            int n2  = int.Parse(Console.ReadLine());
            int n3  = int.Parse(Console.ReadLine());
            
            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("O número maior é = " + resultado);
        }
        static int Maior(int a , int b , int c){
            int m;
            if (a > b && a > c){
                m = a;
            }

            else if(b > c){
                m = b;
            }

            else{
                m = c;
            }

            return m;
        }
        
    }
}
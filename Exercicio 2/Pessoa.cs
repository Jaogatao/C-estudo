using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }

        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da pessoa 1: ");
            Console.Write("Nome da pessoa: ");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Idade dela: ");
            p1.Idade = int.Parse(Console.ReadLine());



            Console.WriteLine("Dados da pessoa 2: ");
            Console.Write("Nome da pessoa: ");
            p2.Nome = Console.ReadLine();

            Console.WriteLine("Idade dela: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade){
                
                Console.WriteLine("Essa pessoa é a com maior idade: " + p1.Nome);

            }
            else{
                Console.WriteLine("Essa pessoa é a com maior idade: " + p2.Nome);
            }


        }
      

    }
}
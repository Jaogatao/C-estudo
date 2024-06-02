using System;
using System.Data;
using System.Globalization;
using Estoque_c_;

namespace course{
    class program{
        static void Main(string[] args){

    Produto p = new Produto();

    Console.WriteLine("Entre com os dados do Produto:");

    Console.Write("Nome:  ");
    p.nome = Console.ReadLine();

    Console.Write("Preço: ");
    p.preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

    Console.Write("Quantidade no Estoque: ");
    p.quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados do determinado Produto: " + p);

    Console.WriteLine("Diga o número de produtos para adicionar e atualizar no estoque: ");
    int qte = int.Parse(Console.ReadLine());
    p.AdicionarProdutos(qte);
    
        Console.WriteLine("Dados atualidados: " + p);

    Console.WriteLine("Diga o número de produtos para Remover e atualizar no estoque: ");
    qte = int.Parse(Console.ReadLine());
    p.RemoverProdutos(qte);

        Console.WriteLine("Dados atualidados: " + p);

}

    }
}
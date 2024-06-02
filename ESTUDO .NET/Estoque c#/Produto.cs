using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque_c_
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValortotalEmEstoque() {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade){
            
            quantidade -= quantidade;
            
        }
        public override string ToString()
        {
            return nome
            + ", $"
            + preco.ToString("F2",CultureInfo.InvariantCulture)
            + ", "
            + quantidade 
            + "unidades , total: $"
            + ValortotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
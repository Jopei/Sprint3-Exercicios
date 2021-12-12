using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio
{
    internal class Produto
    {
        public int cod;
        public string descricao;
        public double valor;
        public Produto(int Cod, string Desc, double Val)
        {
            cod = Cod;
            descricao = Desc;
            valor = Val;
        }
    }
    

}

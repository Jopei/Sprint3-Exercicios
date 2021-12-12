using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio
{
    internal class Cardapio
    {
        List<Produto> Lista = new List<Produto>();
        public void Adcionar(Produto list)
        {
            Lista.Add(list);
        }
        public void ListarCardapio()
        {
            Console.WriteLine("Qual  o item (Codigo) do pedido abaixo? ");
            Console.WriteLine("- Entrada em loop : ");
            Console.WriteLine("Código  Produto   Preço Unitário (R$)");
            for (int i = 0; i < Lista.Count; i++)
            {

                Console.WriteLine(Lista[i].cod + "| " +  Lista[i].descricao + "| R$ " + Lista[i].valor);

            }
        }
        public List<Produto> BuscarCardapio(List<Produto> lista)
        {
            lista = Lista;
            return lista;
        }
    }
}

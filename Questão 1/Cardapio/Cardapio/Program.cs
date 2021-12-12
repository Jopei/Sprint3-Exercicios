using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio
{
    internal class Program
    {
        
        private static void Pedido(Cardapio Lista)
        {
            int mesa, cod, qtd;
            Pedido novoPedido = new Pedido();
            novoPedido.Pedidos(Lista);
            Console.Clear();
            Console.WriteLine("Qual o numero da mesa ?");
            mesa = int.Parse(Console.ReadLine());
            if(mesa < 0 || mesa > 4)
            {
                Console.WriteLine("Mesa indisponivel,Por favor aperte enter para escolher outra escolha outra");
                Console.ReadLine();
                Pedido(Lista);
            }
            else
            {
               
                while(true)
                {
                    Lista.ListarCardapio();
                    Console.WriteLine("informe o codigo do Produto");
                    cod = int.Parse(Console.ReadLine());
                    if(cod == 999)
                    {
                        Console.WriteLine("Imprimindo o Pedido\n");
                        Console.WriteLine("Itens");
                        novoPedido.Imprimir();
                        break;
                    }
                    Console.WriteLine("informe a quantidade do Produto");
                    qtd = int.Parse(Console.ReadLine());
                    novoPedido.ItemSelecionado(cod, qtd);

                }
                

            }

        }
        private static bool Menu(Cardapio Lista)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ PEDIDOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗    ");
            Console.WriteLine("║ 1 EFETUAR PEDIDO                              ║    ");
            Console.WriteLine("║ 2 SAIR                                        ║    ");
            Console.WriteLine("╚═══════════════════════════════════════════════╝    ");

            Console.WriteLine(" ");
            Console.Write("DIGITE UMA OPÇÃO : ");

            switch (Console.ReadLine())
            {
                case "1":
                    Pedido(Lista);
                    return true;
                case "2":
                    return false;
                default:
                    return true;
            }
        }
        static void Produtos()
        {
            
            Cardapio Lista = new Cardapio();
            var produto1 = new Produto(100, "Hamburger simples   ", 6.00);
            var produto2 = new Produto(101, "X-burger            ", 7.50);
            var produto3 = new Produto(102, "X-burger com ovo    ", 8.50);
            var produto4 = new Produto(103, "X-burger Completo   ", 13.50);
            var produto5 = new Produto(104, "Pizza 4P            ", 14.00);
            var produto6 = new Produto(105, "Pizza 8P            ", 22.00);
            var produto7 = new Produto(106, "Batata Cheddar Bacon", 19.00);
            var produto8 = new Produto(107, "Coca Lata 300ML     ", 4.50);
            var produto9 = new Produto(108, "Coca                ", 7.00);
            var produto10 = new Produto(999,"Encerar Pedido      ", 0.00);
            Lista.Adcionar(produto1);
            Lista.Adcionar(produto2);
            Lista.Adcionar(produto3);
            Lista.Adcionar(produto4);
            Lista.Adcionar(produto5);
            Lista.Adcionar(produto6);
            Lista.Adcionar(produto7);
            Lista.Adcionar(produto8);
            Lista.Adcionar(produto9);
            Lista.Adcionar(produto10);
            Menu(Lista);
        }
        static void Main(string[] args)
        {
            Produtos();
            Console.ReadLine();
        }
    }
}

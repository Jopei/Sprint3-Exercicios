using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

using Newtonsoft.Json;
namespace Cardapio
{
    internal class Pedido
    {

        double vtotal = 0.0;
        List<Produto> pedidos = new List<Produto>();
        [JsonProperty("vtotal")]
        Cardapio cardapio = new Cardapio();
        List<Produto> menu = new List<Produto>();
        public void Pedidos(Cardapio Lista)
        {
            menu = Lista.BuscarCardapio(menu);

        }
        public void ItemSelecionado(int cod, int qtd)
        {
            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].cod == cod)
                {
                    pedidos.Add(menu[i]);
                    vtotal = ValorTotal(menu[i].valor, qtd, vtotal);
                    Console.WriteLine("Item adiconado, Enter para continuar seu pedido");
                    //Console.WriteLine("Total até agora " + vtotal);

                    Console.ReadLine();
                    Console.Clear();
                }

            }

        }
        public List<Produto> RetornaPedido()
        {
            return pedidos;
        }
        public double ValorTotal(double val, int qtd, double vtotal)
        {
            double valortotal = 0;
            valortotal = vtotal + (val * qtd);
            return valortotal;
        }
        public void Imprimir()
        {
            //var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\pedido.json");
            //var js = new DataContractJsonSerializer(typeof(List<Produto>));
            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));*/
            //string Strpedido = "";

            var Json = JsonConvert.SerializeObject(pedidos, Formatting.Indented);
            //var Json = JsonConvert.SerializeObject(Strpedido, Formatting.Indented);
            //Console.WriteLine("{ \n" + Json + "\n Valor Total: " + vtotal + "\n}");
            Console.WriteLine(Json +  " Valor Total: " + vtotal.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}

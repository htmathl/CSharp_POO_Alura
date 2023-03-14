using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioLanchonete.Clientes;

namespace DesafioLanchonete.Pedidos
{
    public class Pedido
    {
        public int numPedido;
        public Cliente cliente;
        public ItemPedido itemPedido;
        public double total;
    }
}

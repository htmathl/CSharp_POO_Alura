using DesafioLanchonete.Clientes;
using DesafioLanchonete.Estoque;
using DesafioLanchonete.Pedidos;

Pedido pedido1 = new();
pedido1.cliente = new Cliente();
pedido1.itemPedido = new ItemPedido();
pedido1.itemPedido.produtos = new Produtos();

pedido1.numPedido = 1;
pedido1.cliente.nome = "Pedro";
pedido1.cliente.cpf = "656465654";
pedido1.itemPedido.produtos.produto = "Macarrão";
pedido1.total = 100.6;

Console.WriteLine(pedido1.numPedido);
Console.WriteLine(pedido1.cliente.nome);
Console.WriteLine(pedido1.cliente.cpf);
Console.WriteLine(pedido1.itemPedido.produtos.produto);
Console.WriteLine(pedido1.total);
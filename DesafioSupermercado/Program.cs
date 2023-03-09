using DesafioSupermercado;

Mercado mercado = new();

mercado.fabricante = "Coca-cola";
mercado.nome = "coca";
mercado.qtnEstoque = 5;
mercado.valorUnitario = 3.5;
mercado.valorCompra = 5.7;
mercado.cdgBarras = 524564854;

Console.WriteLine(mercado.fabricante);
Console.WriteLine(mercado.nome);
Console.WriteLine(mercado.qtnEstoque);
Console.WriteLine(mercado.valorCompra);
Console.WriteLine(mercado.valorUnitario);
Console.WriteLine(mercado.cdgBarras);
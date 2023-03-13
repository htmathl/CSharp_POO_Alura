using bytebank;

ContaCorrente contaDoAndre = new();

contaDoAndre.titular = "André Silva";
contaDoAndre.numeroAgencia = 15;
contaDoAndre.conta = "10110-X";
contaDoAndre.saldo = 200;

Console.WriteLine(contaDoAndre.titular);
Console.WriteLine(contaDoAndre.numeroAgencia);
Console.WriteLine(contaDoAndre.conta);
Console.WriteLine(contaDoAndre.saldo);

contaDoAndre.depositar(100);

Console.WriteLine("Depositado! Saldo: " + contaDoAndre.saldo);

if (contaDoAndre.sacar(350))
    Console.WriteLine("Saque realizado! Saldo: " + contaDoAndre.saldo);
else
    Console.WriteLine("Saldo Insuficiente!");

ContaCorrente contaMaria = new();
contaMaria.titular = "Maria Souza";
contaMaria.numeroAgencia = 17;
contaMaria.conta = "2598-7";
contaMaria.saldo = 100;

Console.WriteLine("Saldo Maria: " + contaMaria.saldo);

if (contaDoAndre.tranferir(50, contaMaria))
    Console.WriteLine("Transferência realizada!");
else
    Console.WriteLine("Saldo insuficiente");

Console.WriteLine("Saldo andré: " + contaDoAndre.saldo);
Console.WriteLine("Saldo maria: " + contaMaria.saldo);

//valores padrões da classe
ContaCorrente contaPedro = new();
Console.WriteLine(contaPedro.titular); //vazio (string)
Console.WriteLine(contaPedro.saldo); //0 (número)
Console.WriteLine(contaPedro.numeroAgencia);
Console.WriteLine(contaPedro.conta);

//comparando variaveis
double valor = 300;
double valor2 = valor;
Console.WriteLine();
Console.WriteLine(valor==valor2);
Console.WriteLine(valor);
Console.WriteLine(valor2);

//comparando dois objetos por referência
ContaCorrente contaDoAndre2 = new();
contaDoAndre2.titular = "André Silva";
contaDoAndre2.numeroAgencia = 15;
contaDoAndre2.conta = "10110-X";
contaDoAndre2.saldo = 200;

Console.WriteLine();
Console.WriteLine(contaDoAndre2.titular);
Console.WriteLine(contaDoAndre2.numeroAgencia);
Console.WriteLine(contaDoAndre2.conta);
Console.WriteLine(contaDoAndre2.saldo);

Console.WriteLine(contaDoAndre == contaDoAndre2);

//referencias iguais (true)
contaDoAndre2 = contaDoAndre;
Console.WriteLine();
Console.WriteLine(contaDoAndre == contaDoAndre2);

//desafio modulo 3
Console.WriteLine();
contaMaria.mostrar();
using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaDoAndre = new();

//contaDoAndre.titular = "André Silva";
//contaDoAndre.numeroAgencia = 15;
//contaDoAndre.conta = "10110-X";
//contaDoAndre.saldo = 200;

//Console.WriteLine(contaDoAndre.titular);
//Console.WriteLine(contaDoAndre.numeroAgencia);
//Console.WriteLine(contaDoAndre.conta);
//Console.WriteLine(contaDoAndre.saldo);

//contaDoAndre.depositar(100);

//Console.WriteLine("Depositado! Saldo: " + contaDoAndre.saldo);

//if (contaDoAndre.sacar(350))
//    Console.WriteLine("Saque realizado! Saldo: " + contaDoAndre.saldo);
//else
//    Console.WriteLine("Saldo Insuficiente!");

//ContaCorrente contaMaria = new();
//contaMaria.titular = "Maria Souza";
//contaMaria.numeroAgencia = 17;
//contaMaria.conta = "2598-7";
//contaMaria.saldo = 100;

//Console.WriteLine("Saldo Maria: " + contaMaria.saldo);

//if (contaDoAndre.tranferir(50, contaMaria))
//    Console.WriteLine("Transferência realizada!");
//else
//    Console.WriteLine("Saldo insuficiente");

//Console.WriteLine("Saldo andré: " + contaDoAndre.saldo);
//Console.WriteLine("Saldo maria: " + contaMaria.saldo);

////valores padrões da classe
//ContaCorrente contaPedro = new();
//Console.WriteLine(contaPedro.titular); //vazio (string)
//Console.WriteLine(contaPedro.saldo); //0 (número)
//Console.WriteLine(contaPedro.numeroAgencia);
//Console.WriteLine(contaPedro.conta);

////comparando variaveis
//double valor = 300;
//double valor2 = valor;
//Console.WriteLine();
//Console.WriteLine(valor==valor2);
//Console.WriteLine(valor);
//Console.WriteLine(valor2);

////comparando dois objetos por referência
//ContaCorrente contaDoAndre2 = new();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.numeroAgencia = 15;
//contaDoAndre2.conta = "10110-X";
//contaDoAndre2.saldo = 200;

//Console.WriteLine();
//Console.WriteLine(contaDoAndre2.titular);
//Console.WriteLine(contaDoAndre2.numeroAgencia);
//Console.WriteLine(contaDoAndre2.conta);
//Console.WriteLine(contaDoAndre2.saldo);

//Console.WriteLine(contaDoAndre == contaDoAndre2);

////referencias iguais (true)
//contaDoAndre2 = contaDoAndre;
//Console.WriteLine();
//Console.WriteLine(contaDoAndre == contaDoAndre2);

////desafio modulo 3
//Console.WriteLine();
//contaMaria.mostrar();

//Cliente cliente = new();

//cliente.nome = "André Silva";
//cliente.cpf = "565464688";
//cliente.profissao = "Analista";

//ContaCorrente conta = new();

//conta.titular = cliente;
//conta.conta = "10125-X";
//conta.numeroAgencia = 75;
//conta.saldo = 10000;

//Console.WriteLine("CPF: " + conta.titular.cpf);
//Console.WriteLine("Titular: " + conta.titular.nome);
//Console.WriteLine("Profissão: " + conta.titular.profissao);
//Console.WriteLine("Conta: " + conta.conta);
//Console.WriteLine("Agência: " + conta.numeroAgencia);
//Console.WriteLine("Saldo: " + conta.saldo);
//Console.WriteLine();

//ContaCorrente conta2 = new();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Bezerra";
//conta2.titular.cpf = "1566854523";
//conta2.titular.profissao = "Tester";
//conta2.conta = "5856-X";
//conta2.numeroAgencia = 56;
//conta2.saldo = 560;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new();

//conta3.NumeroAgencia = 18;
//conta3.definirSaldo(500);
//conta3.Conta = "5598-X";
//conta3.Titular = new Cliente();
//conta3.Titular.Cpf = "52496488";

//Console.WriteLine(conta3.recuperarSaldo());
//Console.WriteLine(conta3.NumeroAgencia);
//Console.WriteLine(conta3.Conta);
//Console.WriteLine(conta3.Titular.Cpf);

//ContaCorrente conta4 = new(-1, "20225-L");
//conta4.definirSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.recuperarSaldo());
//Console.WriteLine(conta4.NumeroAgencia);


//Membro estático é relacionado a classe e não ao objeto
ContaCorrente conta5 = new(286, "Miau", new Cliente("claudio", "654444", "Uau"));
Console.WriteLine(conta5.Titular.Profissao);
Console.WriteLine(ContaCorrente.TotalDeContas);


//Membro tem o set privado
//ContaCorrente.TotalDeContas = 100;

ContaCorrente conta6 = new(895, "589-M", new Cliente("sergio", "55748", "ui"));
Console.WriteLine(ContaCorrente.TotalDeContas);

ContaCorrente conta7 = new(895, "589-MM", new Cliente("mauricio", "64587", "aaa"));
Console.WriteLine(ContaCorrente.TotalDeContas);
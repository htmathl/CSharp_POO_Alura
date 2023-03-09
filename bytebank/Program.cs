using bytebank;

ContaCorrente contaDoAndre = new();

contaDoAndre.titular = "André Silva";
contaDoAndre.numeroAgencia = 15;
contaDoAndre.conta = "10110-X";
contaDoAndre.saldo = -200;

Console.WriteLine(contaDoAndre.titular);
Console.WriteLine(contaDoAndre.numeroAgencia);
Console.WriteLine(contaDoAndre.conta);
Console.WriteLine(contaDoAndre.saldo);

contaDoAndre.depositar(100);

Console.WriteLine("Depositado! Saldo: " + contaDoAndre.saldo);
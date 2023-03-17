using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContas { get; private set; }
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            private set { if(value > 0) numeroAgencia = value; }
        }
        //private string conta;
        //o c# cria em tempo de execução uma variável privada
        public string Conta { get; set; }

        public Cliente Titular { get; set; }
        private double saldo = 0;

        public void depositar(double valor)
        {
            saldo += valor;
        }
        public bool sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public bool tranferir(double valor, ContaCorrente destino)
        {
            if (saldo >= valor)
            {
                sacar(valor);
                destino.depositar(valor);
                return true;
            }
            return false;
        }
        //desafio modulo 3
        public void mostrar()
        {
            Console.WriteLine(Titular);
            Console.WriteLine(numeroAgencia);
            Console.WriteLine(Conta);
            Console.WriteLine(saldo);
        }
        public void definirSaldo(double valor)
        {
            if (valor < 0) return;
            saldo = valor;
        }
        public double recuperarSaldo()
        {
            return saldo;
        }
        //É possível ter mais de um método construtor em uma classe
        public ContaCorrente(int numeroAgencia, string numeroConta, Cliente titular)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = numeroConta;
            Titular = titular;
            TotalDeContas++;
        }
    }
}

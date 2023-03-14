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
        public int numeroAgencia;
        public string conta;
        public Cliente titular;
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
            Console.WriteLine(titular);
            Console.WriteLine(numeroAgencia);
            Console.WriteLine(conta);
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
    }
}

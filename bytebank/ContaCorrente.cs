using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int numeroAgencia;
        public string conta;
        public string titular;
        public double saldo = 0;

        public void depositar(double valor)
        {
            this.saldo += valor;
        }
        public bool sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }
        public bool tranferir(double valor, ContaCorrente destino)
        {
            if(this.saldo >= valor)
            {
                this.sacar(valor);
                destino.depositar(valor);
                return true;
            }
            return false;
        }
        //desafio modulo 3
        public void mostrar()
        {
            Console.WriteLine(this.titular);
            Console.WriteLine(this.numeroAgencia);
            Console.WriteLine(this.conta);
            Console.WriteLine(this.saldo);
        }
    }
}

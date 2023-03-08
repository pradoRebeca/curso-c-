using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;
        private string conta;
        private double saldo;

        //Propriedade
        public int Numero_Agencia
        {
            set { numero_agencia = value;}
            get { return numero_agencia;}
        }

        //Propriedade Autoimplementada 
        public string Conta { get; set; }

        private Titular.Cliente titular;

        public void Depositar(double valor)
        {
            this.saldo = this.saldo + valor;
        }


        public void Sacar(double valor)
        {
            
            this.saldo -= valor;

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < 0)
            {
                return true;
            }
            else
            {
                this.saldo -= valor;
                destino.saldo += valor;
                return true;
            }

        }


        public void setSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo += valor;
            }
        }

        public double getSaldo()
        {
            return this.saldo;
        }

    }


}

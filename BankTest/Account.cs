using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BankTest
{
    internal class Account
    {
        public string _numero;
        public string Nome { get; private set; }       
        
        public double Saldo { get; private set; }

        public Account(string nome, double saldoinicial)
        {           
            Nome = nome;
            Saldo = saldoinicial;
        }
           
         

        public string Numero { 
            get { return _numero; }
            set { if (value.Length == 4)
                {
                    _numero = value;
                }
            else { _numero = "Conta não encontrada"; }
            } 
        }

       

        public void Deposito(double valor)
        {
            Saldo += valor; 
        }

        public void Saque(double valor)
        {
            Saldo -= valor +5;
        }

        public override string ToString()
        {
            return $"Conta: {_numero}, titular: {Nome}, saldo: R${Saldo.ToString("F2")}";
        }

    }
}

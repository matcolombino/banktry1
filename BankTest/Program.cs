using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BankTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre o número da conta: ");
            string numero = Console.ReadLine();
            Console.WriteLine("Entre o título da conta:");
            string nome = Console.ReadLine();
            Console.WriteLine("Hávera depósito inicial?");
            string resposta = Console.ReadLine();


            double valor = 0;
            if (resposta == "Sim")
            {   Console.WriteLine("Entre o valor do depósito inicial:");
                valor = double.Parse(Console.ReadLine());
            }

            Account x = new Account(nome, valor);
            x.Numero = numero;
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(x);

            Console.WriteLine("Escolha a operação que deseja realizar: ");
            Console.WriteLine("Digite 1 para realizar um depósito.");
            Console.WriteLine("Digite 2 para realizar um saque.");
            Console.WriteLine("Digite 3 para sair.");

            int choice = int.Parse(Console.ReadLine());
            while (choice <= 3)
            {
                
                if (choice == 1)
                { Console.WriteLine("Digite a quantia que deseja depositar: ");
                x.Deposito(double.Parse(Console.ReadLine()));
                choice = 0;
                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine(x);

                    Console.WriteLine("Deseja realizar alguma outra operação? 1-Depósito| 2-Saque| 3-Sair");
                    choice = int.Parse(Console.ReadLine());
                }
               
                else if (choice == 2) 
                    {
                    Console.WriteLine("Digite a quantia que deseja sacar:");
                    x.Saque(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine(x);

                    Console.WriteLine("Deseja realizar alguma outra operação? 1-Depósito| 2-Saque| 3-Sair");
                    choice = int.Parse(Console.ReadLine());
                }

                

            }
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(x);
            






        }
    }
}

using System;

namespace banco2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, saldo=0;
            int opcao;
            Console.WriteLine("Controle caixa\n\n");

            Console.WriteLine("Escolha uma das opções:\n"+
                "1- Depósito\n"+
                "2- Saque\n"+
                "3- Ver o saldo");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {   case 1:
                    Console.WriteLine("Digite o valor do Depósito:");
                    valor = Convert.ToDouble(Console.ReadLine());
                    saldo = saldo + valor;
                    Console.WriteLine("Depósito Efetuado");
                    break;
                case 2:
                 Console.WriteLine("Digite o valor do Saque:");
                    valor = Convert.ToDouble(Console.ReadLine());
                    saldo = saldo - valor;
                    Console.WriteLine("Saque Efetuado");
                    break;
                default:
                    Console.WriteLine("Saldo:{0}");
                    break;
                   
            }



        }
    }
}

using System;

namespace CSharp_Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Selecione a opcao: ");
            var opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                    System.Console.WriteLine("Seu saldo e R$ 100,00");
                    break;
                case "2":
                    System.Console.WriteLine("Informe o valor do deposito");
                    break;
                case "3":
                    System.Console.WriteLine("Informe o valor do saque");
                    break;
                default:
                    System.Console.WriteLine("Opcao Invalida!");
                    break;
            }
        }
    }
}

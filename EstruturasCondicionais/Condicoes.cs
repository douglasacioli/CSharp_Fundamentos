using System;

namespace CSharp_Fundamentos.EstruturasCondicionais
{
    public class Condicoes
    {
        public void Se()
        {
            var a = 3;
            var b = 2;
            var ativo = true;

            if (a > b && ativo == true)
            {
                System.Console.WriteLine("Condicao verdadeira");
                System.Console.WriteLine("Maior");
            }
            System.Console.WriteLine("Final");
        }

        public void SenaoSe()
        {
            var idade = 21;
            var nota = 6;

            if (idade >= 18)
            {
                System.Console.WriteLine("Maior de idade");
                System.Console.WriteLine("Cadastro autorizado");
            }
            else if (idade >= 16 && idade < 18)
            {
                System.Console.WriteLine("Menor de idade (>16 anos)");
                System.Console.WriteLine("Cadastro autorizado com responsaveis");
            }
            else
            {
                System.Console.WriteLine("Menor de idade");
                System.Console.WriteLine("Cadastro nao autorizado");
            }

            if (nota > 7)
            {
                System.Console.WriteLine("Aprovado");
            }
            else
            {
                System.Console.WriteLine("Reprovado");
            }
            System.Console.WriteLine("Finalizado");
        }

        public void OperadorTernario()
        {
            var mensagem = "";
            var idade = 18;

            //condicao ? VALOR SE VERDADEIRO : VALOR SE FALSO

            mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
            System.Console.WriteLine(mensagem);
        }

        public void Escolha()
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
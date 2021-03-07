using System;

namespace CSharp_Fundamentos.EstruturasRepeticao
{
    public class repeticao
    {
        public void Enquanto()
        {
            int i = 0;
            var versoes = new[] { "1.0", "1.1", "2.0", "3.0" };
            while (i < versoes.Length)
            {
                System.Console.WriteLine(versoes[i]);
                i++;
            }
        }

        public void FacaEnquanto()
        {
            var opcao = "";

            do
            {
                System.Console.WriteLine("Digite uma opção: ");
                System.Console.WriteLine("1 - Saque | 2 - Depósito | 3 - Saldo | 0 - Sair");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        System.Console.WriteLine("Saque Realizado.");
                        break;
                    case "2":
                        System.Console.WriteLine("Depósito realizado.");
                        break;
                    case "3":
                        System.Console.WriteLine("Saldo disponível: R$ 100,00.");
                        break;

                }
            }
            while (opcao != "0");
        }

        public void Para()
        {
            var versoes = new[] { "1.0", "1.1", "2.0", "3.0" };

            for (int i = 0; i < versoes.Length; i++)
            {
                System.Console.WriteLine(versoes[i]);
            }
        }

        public void ParaCada()
        {
            var nomes = new[] { "Douglas", "Arthur", "Andressa" };

            foreach (var item in nomes)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
        }

        public void Break()
        {
            var notas = new int[] { 6, 8, 5, 7, 9 };
            var soma = 0.0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 6)
                {
                    Console.WriteLine("Nenhuma nota pode ser inferior a 6.");
                    soma = 0;
                    break;
                }

                soma += notas[i];
            }

            var media = soma / notas.Length;

            Console.WriteLine("Média: " + media);
        }

        public void Continue()
        {
            var notas = new int[] { 6, 8, 5, 7, 9 };
            var soma = 0.0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 6)
                {
                    Console.WriteLine($"A nota { notas[i] } será desconsiderada.");
                    continue;
                }

                soma += notas[i];
            }

            var media = soma / notas.Length;

            Console.WriteLine("Média: " + media);
        }
    }
}
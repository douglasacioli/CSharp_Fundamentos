using System;

namespace CSharp_Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new[] { "Douglas", "Arthur", "Andressa" };

            foreach (var item in nomes)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

        }

    }
}

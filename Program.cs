using System;

namespace CSharp_Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {   
         
           //ToString Converte uma variavel para o tipo string.
           decimal taxa = 12.98m;
           string taxa2 = taxa.ToString();
                     
           DateTime data = DateTime.Now;
           string data2 = data.ToString();

           string resposta = "12";
           int idade = int.Parse(resposta); //o metodo Parse converte uma string para o tipo que eu estou chamando o metodo (int)

            //a classe Convert possui metodos para fazer conversões entre diferentes tipos de dados.
           int idade2 = Convert.ToInt32(resposta);

           Console.WriteLine(data2);

     
        }
    }
}

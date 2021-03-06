using System;

namespace CSharp_Fundamentos.variaveisETiposdeDados
{
    public class TipoString
    {
        public void Concatena()
        {
            //formas de concatenação
            //concatenação simples
            string nome = "Douglas";
            string sobreNome = "Acioli";
            var nomeCompleto = nome +" "+ sobreNome;
            Console.WriteLine(nomeCompleto);
        }
        public void Interpolacao()
        {
           //interpolação
            string nome = "Douglas";
            string sobreNome = "Acioli";
            var nomeCompleto = $"{nome} {sobreNome}";
            Console.WriteLine(nomeCompleto);
        }

        public void MetodosString()
        {
            string nome = "Douglas";
            string sobreNome = "Acioli";
            var nomeCompleto = $"{nome} {sobreNome}";
            Console.WriteLine(nomeCompleto.ToUpper()); //tudo em Maiusculo
            Console.WriteLine(nomeCompleto.ToLower()); //tudo em Minusculo
            Console.WriteLine(nomeCompleto.Substring(7)); //imprime tudo a partir do indice 7
            Console.WriteLine(nomeCompleto.Substring(0,7)); //imprime do indice 0 ao indice 7
            Console.WriteLine(nomeCompleto.Contains('o')); //retorna true se encontrar o caracter
            Console.WriteLine(nomeCompleto.Contains("XP")); //retorna true se encontrar o valor da string
            Console.WriteLine(nomeCompleto.Contains(sobreNome));//retorna true se encontrar o valor da string
            Console.WriteLine(nomeCompleto.StartsWith("D"));//retorna true se a string começar com D
            Console.WriteLine(nomeCompleto.EndsWith("i"));//retorna true se a string terminar com I
            Console.WriteLine(nomeCompleto.IndexOf('o'));//retorna o indice da primeira ocorrencia de um determinado caracter na string
            Console.WriteLine(nomeCompleto.LastIndexOf('o'));//retorna o indice da ultima ocorrencia de um determinado caracter na string
        }

    }
}
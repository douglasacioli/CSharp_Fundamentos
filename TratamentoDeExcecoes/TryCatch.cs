using System;

namespace CSharp_Fundamentos.TratamentoDeExcecoes
{
    public class TryCatch
    {
        public void Excecao()
        {
            try //linhas que podem causar uma exception ficam dentro do bloco try
            {
                var nomes = new[] { "Douglas", "Arthur", "Andressa" };
                for (int i = 0; i <= nomes.Length; i++)
                {
                    System.Console.WriteLine(nomes[i]);
                }
            }
            catch (Exception ex)//no bloco catch nós decidimos o que fazer com a exception 
            {
                System.Console.WriteLine("Ocorreu um erro: " + ex.Message);
                System.Console.WriteLine("Ocorreu um erro: " + ex.StackTrace);
                //por boas praticas não retornamos esses códigos de erros ao client 
            }

            finally //é executado independente da exception ter sido lançada ou não 
            {
                System.Console.WriteLine("Programa Encerrado!");
            }
        }
    }
}
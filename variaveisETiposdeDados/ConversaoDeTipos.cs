using System;

namespace CSharp_Fundamentos.variaveisETiposdeDados
{
    public class ConversaoDeTipos
    {
        //existem 3 tipos de conversão no C#

        //Conversões Implicitas
        //São to tipo que o compilador consegue gerenciar internamente, 
        //bastando que façamos a atribuição de um valor do tipo diferente a uma variavel de outro tipo.
        public void Implicitas()
        {
            int ano = 2020;
            double ano2 = ano;
            //float
            //decimal
            Console.WriteLine(ano2);
            //todos esses tipos são capazes de receber um valor inteiro e converter naturalmente(implicita)
        }

        //Conversões Explicitas
        //são conversões que assumimos que podemos perder algum dado mas informamos ao compilador que assumiremos esse risco.

        public void Explicita()
        {
            decimal taxa = 12.98m;
            int taxa2 = (int)taxa;

            //atribuimos o valor da variavel taxa a variavel taxa2 e fazemos um casting(conversão explicita)
            //aqui nós informamos ao compilador que o valor que a variavel taxa2 recebe vai ser tratado como um int. 
            //nesse caso as casas decimais são perdidas e apenas a parte inteira é impressa (12).

            Console.WriteLine(taxa2);
        }

        //Conversões com classes auxiliares

        public void ClassesAuxiliares()
        {
            //ToString Converte uma variavel para o tipo string.
           decimal taxa = 12.98m;
           string taxa2 = taxa.ToString();
                     
           DateTime data = DateTime.Now;
           string data2 = data.ToString();
           
           //Parse
           //converte uma string para o tipo que eu estou chamando o metodo (int)
           string resposta = "12";
           int idade = int.Parse(resposta); 

           //a classe Convert possui metodos para fazer conversões entre diferentes tipos de dados.
           int idade2 = Convert.ToInt32(resposta);
        }
    }
}
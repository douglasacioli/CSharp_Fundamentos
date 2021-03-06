using System;

namespace CSharp_Fundamentos.variaveisETiposdeDados
{
    public class VariaveisETipos
    {
         public void variaveis()
        {
            int idade = 37;
            decimal altura = 176;
            string nome = "Doug";
            string email = "douglas.acioli@gmail.com";

            Console.WriteLine($"nome: {nome}, idade: {idade}, altura: {altura}, email: {email}");
        }

        
        //quando não queremos definir um tipo para a variavel e resolvemos deixar essa tarefa para o compilador
        //fazemos isso através da inferencia 
        //o compilador le o dado e define o tipo de dado de acordo com o valor atribuido
         public void inferencia()
        {
            var nome = "Douglas";

            Console.WriteLine($"nome: {nome}");
            //nesse caso temos uma string
        }
    }
}
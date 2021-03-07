using System;

namespace CSharp_Fundamentos.variaveisETiposdeDados
{
    public class Arrays
    {
        public void TiposdeDeclaracoes()
        {
            int [] numeros = new int [4]; //DECLARANDO ARRAY

            numeros[0] = 1; //ATRIBUINDO VALORES
            numeros[1] = 9;
            numeros[2] = 1;
            numeros[3] = 0;
            // Console.WriteLine(numeros[0]); //ACESSANDO VALOR DO INDICE
            
            int [] pares = new int[3] {2,4,6}; //DECLARANDO ARRAY E ATRIBUINDO VALORES

            Console.WriteLine(pares[0]); //ACESSANDO VALOR DO INDICE
        
            int [] impares = new int[] {1,3,5,7}; //DECLARANDO ARRAY E ATRIBUINDO VALORES SEM ESPECIFICAR O TAMANHO DO ARRAY
            Console.WriteLine(impares[0]); //ACESSANDO VALOR DO INDICE

            string [] nomes = new [] {"Douglas","Arthur","Andressa"};
            Console.WriteLine(nomes[0]); //ACESSANDO VALOR DO INDICE

            string [] paises = {"Brasil","Alemanha", "Argentina"}; //NOVO TIPO DE DECLARAÇÃO (SEM A NECESSIDADE DO NEW)
            Console.WriteLine(paises[0]);
            var cidades = new [] {"São Paulo", "Florianópolis", "Curitiba"}; //USANDO INFERENCIA DE TIPO, NESSE CASO TEMOS QUE USAR O NEW 
            Console.WriteLine(cidades[0]);

        }
    }
}
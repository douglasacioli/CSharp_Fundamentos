namespace CSharp_Fundamentos.Operadores
{
    public class Operadores
    {
         public void Aritmeticos()
        {
            var a = 7;
            var b = 3.0m;

            System.Console.WriteLine(a + b);
            System.Console.WriteLine(a - b);
            System.Console.WriteLine(a * b);
            System.Console.WriteLine(a / b); //resultado esperado de uma operação entre inteiros é sempre um inteiro
            //para o resultado vir correto uma das variaveis tem que ser um double, float ou decimal
            System.Console.WriteLine(a % b); //resultado inteiro do resto da divisão
            // 7/3 = 2(inteiro) 
            // 2*3 = 6
            // 7-6 = 1

            System.Console.WriteLine(1 + 2);
            System.Console.WriteLine(a - 2);

            var c = 10 - b;
            System.Console.WriteLine(c);

        }

        public void Atribuicao()
        {
            var a = 5;
            var b = 5;
            var c = 5;
            var d = 5;
            var e = 5;

            a += 2; //a = a + 2;
            b -= 2; //b = b - 2;
            c *= 2; //c = c * 2;
            d /= 2; //d = d / 2;
            e %= 2; //e = e % 2;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
            System.Console.WriteLine(e);
        }

        public void Unarios()
        {
            var a = 5;
            var b = 5;

            a++; //incrementa +1 em a (incrementa após a execução)
            ++a; //incrementa antes da execução
            b--; //decrementa -1 em b (decrementa após a execução)
            --b; //decrementa antes da execução
        }

        public void Comparacao()
        {
            var a = 2;
            var b = 3;
            var iguais = a == b; //verifica se a é igual a b (true)
            var diferentes = a != b; //verifica se a é diferente de b(true)
            var maior = a > b; //false
            var menor = a < b; //true
            var maiorOuIgual = a >= b; //false
            var menorOuIgual = a <= b; //true
            System.Console.WriteLine(menorOuIgual);
        }

        public void Logicos()
        {
            var ativo = true;
            var a = 3;
            var b = 5;
            // System.Console.WriteLine(!ativo); //o operador ! nega qualquer expressão 
            //operador &&
            System.Console.WriteLine(ativo == false && a<b);
            //operador ||
            System.Console.WriteLine(ativo == true || a>b);
        }
    }
}
using System;

namespace CSharp_Fundamentos.variaveisETiposdeDados
{
    public class TipoDateTime
    {
        public void Datas()
        {
            var hoje = DateTime.Today; //Data 
            var agora = DateTime.Now; //Data e Hora
            var data1 = new DateTime(2020, 03, 28);
            var data2 = new DateTime(2020, 03, 28, 11, 25, 30);
            var data3 = DateTime.Parse("15/08/2020 12:21:52");
            Console.WriteLine(hoje);
            Console.WriteLine(agora);
            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3);

            Console.WriteLine(data3.Date); //dia
            Console.WriteLine(data3.Month); //mes
            Console.WriteLine(data3.Year); //ano
            Console.WriteLine(data3.Hour); //hora
            Console.WriteLine(data3.Minute); //minutos
            Console.WriteLine(data3.Second); //segundos...milisegundos
            Console.WriteLine(data3.AddDays(5)); //adicionando 5 dias a data ...year...
            Console.WriteLine(data3.AddMonths(-1)); //subtraindo 1 mes da data

            //formatar datas
            Console.WriteLine(data3.ToLongDateString()); //representação extendida da Data
            Console.WriteLine(data3.ToLongTimeString()); //representação extendida da Hora
            Console.WriteLine(data3.ToShortDateString()); //representação Curta da Hora
            Console.WriteLine(data3.ToShortTimeString()); //representação Curta da Hora
        }
    }
}
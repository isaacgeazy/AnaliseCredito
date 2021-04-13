using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal emprest, parc, rendamen, calcporc, calcparc;

            Console.Write("Valor do Empréstimo: ");
            emprest = decimal.Parse(Console.ReadLine());

            Console.Write("Parcelas: ");
            parc = decimal.Parse(Console.ReadLine());

            Console.Write("Renda Mensal: ");
            rendamen = decimal.Parse(Console.ReadLine());

            calcparc = parc / emprest;
            calcporc = (30 * rendamen) / 100;


            if (calcporc < calcparc) {

                Console.WriteLine("Não foi possivel solicitar seu empréstimo.");

            } else {

                Console.Write("Foi possivel fazer seu empréstimo");
            }


        }
    }
}

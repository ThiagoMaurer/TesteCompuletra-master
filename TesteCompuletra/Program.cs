using Negocio;
using System;

namespace TesteCompuletra
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello world
            var automato = new AutomatoEscritor();

            // Não Mudar
            //----------------------------------------------------
            Executa.ExecutaAutomato(automato);
            //----------------------------------------------------
            Console.WriteLine("Aperte ENTER para ir para a próxima funcionalidade");
            Console.ReadKey();
            Console.WriteLine(""); //espaco pra ficar bonito la no console kkkk

            //hora do sistema
            var automatoHora = new AutomatoHoraSistema();
            Executa.ExecutaAutomato(automatoHora);
            Console.WriteLine("Aperte ENTER para ir para a próxima funcionalidade");
            Console.ReadKey();
            Console.WriteLine("");

            //substituicao de falhas
            var automatoSubstituicao = new AutomatoSubstituicao();
            Executa.ExecutaAutomato(automatoSubstituicao);
            Console.WriteLine("Aperte ENTER para ir para a próxima funcionalidade");
            Console.ReadKey();
            Console.WriteLine("");

            //palindromo
            var automatoPalindromo = new AutomatoPalindromo();
            Executa.ExecutaAutomato(automatoPalindromo);

        }
    }
}

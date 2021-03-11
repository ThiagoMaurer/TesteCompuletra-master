// Não Mudar
//--------------------------------------------------------------
using Negocio.Interface;
using System;

namespace Negocio
{
    public class AutomatoEscritor : IAutomatoEscritor
    {
        public string Mensagem { get; set; }

        public virtual void Escreve()
        {
            Mensagem = "Ola Mundo!";
            Console.WriteLine(Mensagem);
        }
    }
}
//--------------------------------------------------------------

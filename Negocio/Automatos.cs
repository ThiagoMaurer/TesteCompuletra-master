using Negocio.Interface;
using System;

namespace Negocio
{
    public class AutomatoHoraSistema : AutomatoEscritor
    {
        public override void Escreve()
        {
            Mensagem = "Olá, agora a hora atual do sistema é " + DateTime.Now.ToString();
            Console.WriteLine(Mensagem);
        }
    }

    public class AutomatoSubstituicao : AutomatoEscritor
    {
        private int FalhaTamanho { get; }

        public AutomatoSubstituicao() {
            FalhaTamanho = 5;
        }

        public override void Escreve()
        {
            Console.WriteLine("Digite uma mensagem para substituir todas as ocorrências de \"Falha\" por \"Sucesso\": ");
            string mensagemSubstituir = Console.ReadLine();

            string procuraFalha = "";
            for (int i = 0; i < mensagemSubstituir.Length - 4; i++) {
                procuraFalha = mensagemSubstituir.Substring(i, FalhaTamanho);

                if (procuraFalha.ToUpper() == "FALHA") {
                    string mensagemAuxiliar = mensagemSubstituir.Substring(0, i); //pega tudo antes do "Falha"
                    mensagemAuxiliar += "Sucesso"; //adiciona o sucesso no lugar
                    mensagemAuxiliar += mensagemSubstituir.Substring((i + FalhaTamanho), (mensagemSubstituir.Length - (i + FalhaTamanho)));
                    mensagemSubstituir = mensagemAuxiliar;
                }
            }
            Console.WriteLine("Mensagem após as substituições: " + mensagemSubstituir);
        }
    }

    public class AutomatoPalindromo : AutomatoEscritor {
        public override void Escreve()
        {
            Console.WriteLine("Digite um número para encontrar o próximo palíndromo: ");
            try {
                int numero = int.Parse(Console.ReadLine());

                bool flag = true;
                string strNumero = numero.ToString();
                string strNumeroContrario = "";

                while (flag)
                {
                    strNumeroContrario = "";
                    for (int i = strNumero.Length; i > 0; i--) {
                        strNumeroContrario += strNumero[i-1];
                    }

                    if (strNumero == strNumeroContrario) {
                        Console.WriteLine("É um palíndromo: " + strNumero + " == " + strNumeroContrario);
                        flag = false;
                    }
                    else {
                        Console.WriteLine("Não é um palíndromo: " + strNumero + " != " + strNumeroContrario);
                        strNumero = (int.Parse(strNumero)+1).ToString();
                    }

                }
            }
            catch (Exception ex) {
                Console.WriteLine("Você deve digitar um número válido.");
                Console.WriteLine("Erro: " + ex.Message);
                Console.ReadKey();
                Console.WriteLine();
                Escreve();
            }
        }       
    }
}

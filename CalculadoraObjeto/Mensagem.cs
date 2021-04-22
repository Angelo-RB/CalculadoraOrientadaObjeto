using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraObjeto
{
    class Mensagem
    {
        public void MostrarMensagem(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(mensagem);

            Console.ResetColor();

            Console.ReadLine();

            Console.Clear();
        }

        public bool EhOpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3"
                                && opcao != "4" && opcao != "5"
                                && opcao != "S" && opcao != "s";

        }

        public bool SegundoNumeroInvalido(string opcao, double segundoNumero)
        {
            return opcao == "4" && segundoNumero == 0;
        }
    }
}

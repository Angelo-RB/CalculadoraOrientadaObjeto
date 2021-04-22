using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraObjeto
{
    class Obter
    {
        public string ObterSimbolo(string opcao)
        {
            string simboloOperacao = "";

            switch (opcao)
            {
                case "1":
                    simboloOperacao = "+";
                    break;

                case "2":
                    simboloOperacao = "-";
                    break;

                case "3":
                    simboloOperacao = "+";
                    break;

                case "4":
                    simboloOperacao = "+";
                    break;

                default:
                    break;
            }
            return simboloOperacao;
        }

        public double ObterNumero(string ordem)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Digite o {ordem} número: ");          

            double numero = Convert.ToDouble(Console.ReadLine());

            return numero;
        }
    }
}

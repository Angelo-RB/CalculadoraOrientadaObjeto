using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraObjeto
{
    class Calculos
    {
        public double CalcularResultado(string opcao, double primeiroNumero, double segundoNumero)
        {
            double resultado = 0;

            switch (opcao)
            {
                case "1": resultado = primeiroNumero + segundoNumero; break;

                case "2": resultado = primeiroNumero - segundoNumero; break;

                case "3": resultado = primeiroNumero * segundoNumero; break;

                case "4": resultado = primeiroNumero / segundoNumero; break;

                default:
                    break;
            }
            return resultado;
        }
    }
}

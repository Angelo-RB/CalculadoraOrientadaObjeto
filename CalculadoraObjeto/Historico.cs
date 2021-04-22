using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraObjeto
{
    class Historico
    {
        public void MostrarOperacoesRealizadas(string[] operacoesRealizadas)
        {
            for (int i = 0; i < operacoesRealizadas.Length; i++)
            {
                if (operacoesRealizadas[i] != null)
                    Console.WriteLine(operacoesRealizadas[i]);
            }
        }
    }
}

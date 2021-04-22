using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraObjeto
{
    class Opcoes
    {
        public bool EhOpcaoSair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }

        public bool EhOpcaoVisualizacao(string opcao)
        {
            return opcao == "5";
        }
    }
}

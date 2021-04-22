using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraObjeto
{
    class Menu
    {
        public void MostrarMenu() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("||=============(Calculadora Tabajara 1.7.1)=============||");

            Console.WriteLine("||                                                      ||");

            Console.WriteLine("||                       Digite:                        ||");

            Console.WriteLine("||                                                      ||");

            Console.WriteLine("||                   1 para somar                       ||");

            Console.WriteLine("||                 2 para subtrair                      ||");

            Console.WriteLine("||               3 para multiplicação                   ||");

            Console.WriteLine("||                 4 para divisão                       ||");

            Console.WriteLine("||       5 para visualizar as operações realizadas      ||");

            Console.WriteLine("||                  S para sair                         ||");
                                               
            Console.WriteLine("||======================================================||");
        }
    }
}

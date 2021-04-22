using System;

namespace CalculadoraObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu Mostrar = new Menu();

            Mensagem MensagemMostrar = new Mensagem();
            Mensagem MenagemOpcaoInvalida = new Mensagem();
            Mensagem Mensagem2NInvalido = new Mensagem();

            Opcoes Opsair = new Opcoes();
            Opcoes Opvisualizacao = new Opcoes();

            Obter Simbolo = new Obter();
            Obter Numero = new Obter();

            Calculos CalculosSimples = new Calculos();

            Historico HistoricoCalculadora = new Historico();

            string[] operacoesRealizadas = new string[100];
            string opcao = "";
            int contadorOperacoesRealizadas = 0;

            while (true)
            {
                Mostrar.MostrarMenu();

                Console.WriteLine();
                opcao = Console.ReadLine();


                if (MenagemOpcaoInvalida.EhOpcaoInvalida(opcao)) 
                {
                    string mensagemDeErro = "***! Opção inválida! Tente novamente !***";

                    MensagemMostrar.MostrarMensagem(mensagemDeErro);

                    continue;
                }

                if (Opvisualizacao.EhOpcaoVisualizacao(opcao))
                {
                    Console.WriteLine();

                    if (contadorOperacoesRealizadas == 0)
                        MensagemMostrar.MostrarMensagem("***! Nenhuma operação foi realizada ainda. Tente novamente !***");

                    else
                        HistoricoCalculadora.MostrarOperacoesRealizadas(operacoesRealizadas);

                    Console.ReadLine();

                    Console.Clear();

                    continue;
                }
                if (Opsair.EhOpcaoSair(opcao))
                    break;


                double primeiroNumero, segundoNumero;


                primeiroNumero = Numero.ObterNumero("primeiro");

                do
                {
                    segundoNumero = Numero.ObterNumero("segundo");

                    if (Mensagem2NInvalido.SegundoNumeroInvalido(opcao, segundoNumero))
                    {
                        MensagemMostrar.MostrarMensagem("***! Segundo número inválido! Tente novamente !***");
                    }

                } while (Mensagem2NInvalido.SegundoNumeroInvalido(opcao, segundoNumero));

                double resultado = CalculosSimples.CalcularResultado(opcao, primeiroNumero, segundoNumero);

                string operacaoRealizada =
                    $"{primeiroNumero} { Simbolo.ObterSimbolo(opcao)} {segundoNumero} = {resultado}";


                operacoesRealizadas[contadorOperacoesRealizadas] = operacaoRealizada;

                contadorOperacoesRealizadas++;

                Console.WriteLine(resultado);

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();

            }
        }                
    
    }
    
}

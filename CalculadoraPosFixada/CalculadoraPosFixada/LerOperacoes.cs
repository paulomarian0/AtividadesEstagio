using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPosFixada
{
    class LerOperacoes
    {


        public static List<char> LerOperacao(List<char> lista, int nElementos)
        {
            int cont = 1;
            string op;
            char operacao;
            if (nElementos > 1)
            {
                Menu.ExibirMenu();

                while (cont < nElementos)
                {
                    op = Console.ReadLine();

                    if (char.TryParse(op, out operacao))
                    {
                        if (operacao == '+' || operacao == '-' || operacao == '*' || operacao == '/')
                        {
                            lista.Add(operacao);
                            cont++;
                        }
                    }

                }
            }
            return lista;
        }
    }
}

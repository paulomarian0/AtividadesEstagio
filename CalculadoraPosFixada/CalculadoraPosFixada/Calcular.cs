using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPosFixada
{
    class Calcular
    {
        public static void EfetuaCalculo(List<double> listaNumeros, List<char> listaOperacoes)
        {
            double total = listaNumeros[0];

            Console.Write(listaNumeros[0]);
            //Efetua os calculos e print das operações
            for (int i = 0; i < listaOperacoes.Count; i++)
            {
                if (listaOperacoes[i] == '+')
                {
                    total = Somar.SomarNumeros(total, listaNumeros[i + 1]);
                }
                else if (listaOperacoes[i] == '/')
                {
                    total = Dividir.DividirNumeros(total, listaNumeros[i + 1]);
                }
                else if (listaOperacoes[i] == '-')
                {
                    total = Subtrair.SubtrairNumeros(total, listaNumeros[i + 1]);
                }
                else
                {
                    total = Multiplicar.MultiplicarNumeros(total, listaNumeros[i + 1]);
                }

                Console.Write(" " + listaOperacoes[i] + " ");
                Console.Write(listaNumeros[i + 1]);
            }
            Console.WriteLine(" = " + total);
        }


    }
}

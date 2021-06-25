using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraPosFixada
{
    class Program
    {
   
        public static void Main(string[] args)
        {
            List<double> numeros = new List<double>();
            List<char> operacoes = new List<char>();


            numeros.Clear();
            operacoes.Clear();

            numeros = LerNumeros.LerNumero(numeros);
            Console.Clear();
            operacoes = LerOperacoes.LerOperacao(operacoes, numeros.Count);
            Console.Clear();


            if (numeros.Count > 0)
            {
                Calcular.EfetuaCalculo(numeros, operacoes);
            }

        }


    }
}
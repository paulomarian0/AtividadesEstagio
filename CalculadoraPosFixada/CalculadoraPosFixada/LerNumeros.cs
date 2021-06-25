using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraPosFixada
{
    class LerNumeros
    {

        public static List<double> LerNumero(List<double> lista)
        {
            double numero;
            string entradaString;

            Console.WriteLine("Digite o número que deseja:");
            Console.WriteLine("Para parar de digitar os numeros, digite QUALQUER STRING:");
            do
            {
                entradaString = Console.ReadLine();
                // Funcão pra verificar se a entrada é uma string
                if (entradaString.All(char.IsDigit))
                {
                    if (double.TryParse(entradaString, out numero))
                    {
                        lista.Add(numero);
                    }

                }

            } while (entradaString.All(char.IsDigit));
            return lista;
        }
    }
}

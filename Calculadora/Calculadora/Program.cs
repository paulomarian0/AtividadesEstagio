using System;

namespace ConsoleApp1
{
    class Program
    {
        static double Somar(double valor1, double valor2)
        {
            double resultado = valor1 + valor2;


            return resultado;
        }

        static double Subtrair(double valor1, double valor2)
        {
            double resultado = valor1 - valor2;


            return resultado;
        }


        static double Multiplicar(double valor1, double valor2)
        {
            double resultado = valor1 * valor2;

            return resultado;
        }

        static double Divisao(double valor1, double valor2)
        {
            double resultado = valor1 / valor2;


            return resultado;
        }

        static void Menu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("Digite 1 para SOMAR");
            Console.WriteLine("Digite 2 para SUBTRAIR");
            Console.WriteLine("Digite 3 para MULTIPLICAR");
            Console.WriteLine("Digite 4 para DIVIDIR");
            Console.WriteLine("---FIM DO MENU---\n");

        }

        static void Main(string[] args)
        {


            bool saida = false;
            int entrada;



            do
            {

                Menu();

                Console.WriteLine("Entre com o valor:");
                entrada = Convert.ToInt32(Console.ReadLine());

                if (entrada < 1 || entrada > 4)
                {
                    saida = true;

                    Console.Clear();

                }
                else
                {
                    saida = false;
                }

            } while (saida);

            Console.WriteLine("Digite o valor 1:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor 2:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            switch (entrada)
            {
                case 1:
                    Console.WriteLine(Somar(valor1, valor2));
                    break;

                case 2:
                    Console.WriteLine(Subtrair(valor1, valor2));

                    break;

                case 3:
                    Console.WriteLine(Multiplicar(valor1, valor2));
                    break;

                case 4:
                    Console.WriteLine(Divisao(valor1, valor2));
                    break;


            }
        }
    }
}
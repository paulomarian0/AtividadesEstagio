using System;
using System.Collections.Generic;
using System.Text;

namespace VilaoEletrico
{
    class ClasseMenu
    {

        public static void Menu(DadoTarifaEConta dados)
        {

            bool cond = true;

            Console.WriteLine("Entre com o valor da tarifa:");
            dados.ValorTarifa = Convert.ToDouble(Console.ReadLine());


            while (cond == true)
            {


                Console.WriteLine("Insira a bandeira tributária do mês (VERDE, AMARELA, VERMELHA1, VERMELHA2:");
                dados.Bandeira = Console.ReadLine().ToLower();

                if (dados.Bandeira != "vermelha" && dados.Bandeira != "vermelha1" && dados.Bandeira != "vermelha2" && dados.Bandeira != "verde" && dados.Bandeira != "amarela")
                {
                    Console.WriteLine("ENTRADA INVÁLIDA");

                    cond = true;
                }
                else
                {
                    cond = false;
                }
            }
            Console.WriteLine("Entre com o valor do imposto PIS em porcentagem");
            dados.PIS = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o valor do imposto COFINS em porcentagem");
            dados.COFINS = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o valor do imposto ICMS em porcentagem");
            dados.ICMS = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------");

        }
    }
}

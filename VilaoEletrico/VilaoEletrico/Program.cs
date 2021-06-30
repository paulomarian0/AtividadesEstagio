using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

// INCOMPLETO
namespace VilaoEletrico
{

    class Program
    {
        public static void Main(string[] args)
        {
            DadoTarifaEConta dado = new DadoTarifaEConta();
            List<ObjetoCasa> objetosDaCasa = new List<ObjetoCasa>();

            Console.WriteLine("Quantos dados deseja inserir?");
            int entrada = Convert.ToInt32(Console.ReadLine());

            string[] nome = new string[entrada];
            string[] local = new string[entrada];
            double[] consumowatts = new double[entrada];
            int[] tempo = new int[entrada];
            double ValorTotal = 35.20; // CUSTO ILUMINAÇÃO PUBLICA
            bool cond = true;
            // FALTA SEPARAR AS CLASSES EM CADA ARQUIVO E ADICIONAR UM RETORNO QUANDO A BANDEIRA FOR INVÁLIDA

            Console.WriteLine("Entre com o valor da tarifa:");
            dado.ValorTarifa = Convert.ToDouble(Console.ReadLine());

            while (cond == true)
            {
                Console.WriteLine("Insira a bandeira tributária do mês (VERDE, AMARELA, VERMELHA1, VERMELHA2:");
                dado.Bandeira = Console.ReadLine().ToLower();

                if (dado.Bandeira != "vermelha" && dado.Bandeira != "vermelha1" && dado.Bandeira != "vermelha2" && dado.Bandeira != "verde" && dado.Bandeira != "amarela")
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
            dado.PIS = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o valor do imposto COFINS em porcentagem");
            dado.COFINS = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o valor do imposto ICMS em porcentagem");
            dado.ICMS = Convert.ToDouble(Console.ReadLine());

            /////////////////////////////////////////////////////
            int maiorUso = 0;
            int menorUso = 0;
            int maiorConsumo = 0;
            int menorConsumo = 0;

            for (int i = 0; i < entrada; i++)
            {

                Console.WriteLine("Entre com o nome do aparelho");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Entre com o nome do local");
                local[i] = Console.ReadLine();

                Console.WriteLine("Entre com o valor do consumo em Watt/h");
                consumowatts[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Entre com o tempo de uso diário do item");
                tempo[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---------------------");

                //organizar tempo maior
                for (int j = 0; j < entrada; j++)
                {
                    if (tempo[j] > tempo[maiorUso])
                    {
                        maiorUso = j;
                    }

                    //organizar tempo menor
                    if (tempo[j] < tempo[menorUso])
                    {
                        menorUso = j;
                    }

                    // organizar consumo maior

                    if (consumowatts[j] > consumowatts[maiorConsumo])
                    {
                        maiorConsumo = j;
                    }

                    //organizar consumo menor

                    if (consumowatts[j] < consumowatts[menorConsumo])
                    {
                        menorConsumo = j;
                    }
                }
                double resultadoParcial;
                double resultadoPIS;
                double resultadoCOFINS;
                double ConsumoMes = (consumowatts[i] / 1000) * tempo[i] * 30;

                resultadoParcial = ConsumoMes * dado.ValorTarifa;
                resultadoPIS = (dado.PIS / 100) * resultadoParcial;            //dividido por 100 para conseguir o valor correto pro cálculo
                resultadoCOFINS = (dado.COFINS / 100) * resultadoParcial;    //dividido por 100 para conseguir o valor correto pro cálculo
                ValorTotal += (resultadoPIS + resultadoCOFINS + ConsumoMes) * ((dado.ICMS / 100) + 1); //1.25 = 25% de acréscimo

                objetosDaCasa.Add(new ObjetoCasa() { Nome = nome[i], Local = local[i], ConsumoWatts = consumowatts[i], TempoUsoDia = tempo[i] });
            }
            foreach (var item in objetosDaCasa)
            {
                Console.WriteLine("Nome do item: {0} ", item.Nome);
                Console.WriteLine("Nome do local : {0}", item.Local);
                Console.WriteLine("Consumo do item em Kw/h: {0}", item.ConsumoWatts);
                Console.WriteLine("Tempo de uso no dia : {0}", item.TempoUsoDia);
                Console.WriteLine("Bandeira: {0}", dado.Bandeira);
                Console.WriteLine("---------------------------------------------");
            }
            Console.WriteLine("Valor total a se pagar {0}:", ValorTotal);
            Console.WriteLine("O local com MAIOR tempo de uso {0}", local[maiorUso]);
            Console.WriteLine("O local com MENOR gasto de uso {0}", local[menorConsumo]);
            Console.WriteLine("O local com MENOR tempo foi {0}", local[menorUso]);
            Console.WriteLine("O local com MAIOR gasto foi {0}", local[maiorConsumo]);
        }
    }
}

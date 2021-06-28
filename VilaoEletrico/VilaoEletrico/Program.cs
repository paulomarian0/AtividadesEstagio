using System;
using System.Collections;


// INCOMPLETO

namespace VilaoEletrico
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int x = 2;

            string[] local = new string[x];
            string[] nome = new string[x];


            int[] consumo = new int[x];
            int[] tempoUso = new int[x];

            string[] bandeira = new string[x];

            double[] valorTarifa = new double[x];
            double[] ICMS = new double[x];
            double[] PIS = new double[x];
            double[] COFINS = new double[x];

            double[] valorPagar = new double[x];


            int maiorUso = 0;
            int menorUso = 0;
            int maiorConsumo = 0;
            int menorConsumo = 0;

            

            // 

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("INSIRA SE É CASA OU APARTAMENTO");
                string entradaNome = Console.ReadLine();
                nome[i] = entradaNome;


                Console.WriteLine("INSIRA O NOME DA CIDADE");
                string entradaLocal = Console.ReadLine();
                local[i] = entradaLocal;


                Console.WriteLine("INSIRA O TEMPO DE USO DO {0}:", local[i]);
                int entradaUso = Convert.ToInt32(Console.ReadLine());
                tempoUso[i] = entradaUso;


                Console.WriteLine("INSIRA O VALOR DE CONSUMO {0}:", local[i]);
                int entradaConsumo = Convert.ToInt32(Console.ReadLine());
                consumo[i] = entradaConsumo;

                Console.WriteLine("INSIRA VALOR DA TARIFA EM KW/H {0}:", local[i]);
                int entradaTarifa = Convert.ToInt32(Console.ReadLine());
                valorTarifa[i] = entradaTarifa;

                Console.WriteLine("INSIRA A BANDEIRA (VERDE, AMARELA OU VERMELHA)");
                string entradaBandeira = Console.ReadLine();
                bandeira[i] = entradaBandeira;

                Console.WriteLine("INSIRA O ICMS de  {0}:", local[i]);
                double entradaICMS = Convert.ToDouble(Console.ReadLine());
                ICMS[i] = entradaICMS;

                Console.WriteLine("INSIRA O PIS de {0}:", local[i]);
                double entradaPIS = Convert.ToDouble(Console.ReadLine());
                PIS[i] = entradaPIS;

                Console.WriteLine("INSIRA O COFINS de {0}:", local[i]);
                double entradaCOFINS = Convert.ToDouble(Console.ReadLine());
                COFINS[i] = entradaCOFINS;

                valorPagar[i] = consumo[i] * (ICMS[i] + COFINS[i] + PIS[i]);

                Console.WriteLine("----------------");

            }

            //organizar tempo maior
            for (int i = 0; i < x; i++)
            {
                if (tempoUso[i] > tempoUso[maiorUso])
                {
                    maiorUso = i;
                }
            }

            //organizar tempo menor
            for (int i = 0; i < x; i++)
            {
                if (tempoUso[i] < tempoUso[menorUso])
                {
                    menorUso = i;
                }
            }
            // organizar consumo maior
            for (int i = 0; i < x; i++)
            {
                if (consumo[i] > consumo[maiorConsumo])
                {
                    maiorConsumo = i;
                }
            }

            //organizar consumo menor
            for (int i = 0; i < x; i++)
            {
                if (consumo[i] < consumo[menorConsumo])
                {
                    menorConsumo = i;
                }
            }

            // Console.WriteLine("O maior número é no indice [{0}]", maior);
            Console.WriteLine("----------------------------");
            Console.WriteLine("O local com MAIOR tempo de uso {0}", local[maiorUso]);
            Console.WriteLine("O local com MENOR tempo de uso {0}", local[menorUso]);
            Console.WriteLine("O local com MAIOR gasto foi {0}", local[maiorConsumo]);
            Console.WriteLine("O local com MENOR gasto foi {0}", local[menorConsumo]);



            Console.WriteLine("EXIBIÇÃO DE TODOS OS VALORES");

            for (int i = 0; i < x; i++)
            {

                Console.WriteLine("------------");
                Console.WriteLine("APARTAMENTO OU CASA: {0} ", nome[i]);
                Console.WriteLine("CIDADE: {0} ", local[i]);
                Console.WriteLine("CONSUMO EM W/H: {0}", consumo[i]);
                Console.WriteLine("TEMPO DE USO NO MÊS: {0}", tempoUso[i]);


                Console.WriteLine("VALOR TARIFA EM KW/h: {0}", valorTarifa[i]);
                Console.WriteLine("BANDEIRA: {0}", bandeira[i]);
                Console.WriteLine("ICMS EM % :{0}", ICMS[i]);
                Console.WriteLine("PIS EM % :{0}", PIS[i]);
                Console.WriteLine("COFINS EM % :{0}", COFINS[i]);

                Console.WriteLine("VALOR A SE PAGAR: {0}", valorPagar[i]);

            }

        }
    }
}

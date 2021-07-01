using System;
using System.Collections.Generic;

namespace VilaoEletrico
{
    class Program
    {
        public static void Main(string[] args)
        {
            DadoTarifaEConta dado = new DadoTarifaEConta();
            List<ObjetoCasa> objetosDaCasa = new List<ObjetoCasa>();

            double ValorTotal = 35.20; // valor da iluminação pública
            double somaICMS = 0;
            double somaPIS = 0;
            double somaCOFINS = 0;

            bool condicao = true;

            ClasseMenu.Menu(dado);

            while (condicao)
            {
                /////////////////////////////////////////////////////
                ObjetoCasa objetoCasa = new ObjetoCasa();

                Console.WriteLine("Entre com o nome do aparelho");
                string vnome = Console.ReadLine();
                objetoCasa.Nome = vnome;

                Console.WriteLine("Entre com o nome do local");
                string localv = Console.ReadLine();
                objetoCasa.Local = (localv);

                Console.WriteLine("Entre com o valor do consumo em Watt/h");
                double consumov = Convert.ToDouble(Console.ReadLine());
                objetoCasa.ConsumoWatts = (consumov);

                Console.WriteLine("Entre com o tempo de uso diário do item EM HORAS");
                double tempov = Convert.ToDouble(Console.ReadLine());
                objetoCasa.TempoUsoDia = (tempov);

                objetosDaCasa.Add(objetoCasa);

                Console.WriteLine("---------------------");

                Console.WriteLine("Deseja inserir novos dados? (S,N) ");
                char fimPrograma = Convert.ToChar(Console.ReadLine());

                if (fimPrograma == 'n' || fimPrograma == 'N')
                {
                    condicao = false;
                }

                double resultadoParcial;
                double resultadoPIS;
                double resultadoCOFINS;
                double ConsumoMes = (objetoCasa.ConsumoWatts / 1000) * objetoCasa.TempoUsoDia * 30;

                resultadoParcial = ConsumoMes * dado.ValorTarifa;
                resultadoPIS = (dado.PIS / 100) * resultadoParcial;            //dividido por 100 para conseguir o valor correto pro cálculo
                resultadoCOFINS = (dado.COFINS / 100) * resultadoParcial;    //dividido por 100 para conseguir o valor correto pro cálculo
                ValorTotal += (resultadoPIS + resultadoCOFINS + ConsumoMes) * ((dado.ICMS / 100) + 1); //1.25 = 25% de acréscimo

                somaPIS += resultadoPIS;
                somaICMS += (dado.ICMS / 100) * resultadoParcial;
                somaCOFINS = resultadoCOFINS;

            }

            ObjetoCasa objMaiorC = Calculos.MaiorConsumo(objetosDaCasa);
            ObjetoCasa objMenorC = Calculos.MenorConsumo(objetosDaCasa);
            ObjetoCasa objMaiorT = Calculos.MaiorTempoDeUso(objetosDaCasa);
            ObjetoCasa objMenorT = Calculos.MenorTempoDeUso(objetosDaCasa);

            foreach (var item in objetosDaCasa)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Nome do item: {0} ", item.Nome);
                Console.WriteLine("Nome do local : {0}", item.Local);
                Console.WriteLine("Consumo do item em Kw/h: {0}", item.ConsumoWatts);
                Console.WriteLine("Tempo de uso no dia : {0}", item.TempoUsoDia);
                Console.WriteLine("Bandeira: {0}", dado.Bandeira);
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Valor total a se pagar: {0}", Math.Round(ValorTotal, 2));

            Console.WriteLine("Valor somado do PIS: {0}", Math.Round(somaPIS, 2));
            Console.WriteLine("Valor somado do COFINS: {0}", Math.Round(somaCOFINS, 2));
            Console.WriteLine("Valor somado do ICMS: {0}", Math.Round(somaICMS, 2));

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("O local com MAIOR tempo de uso {0}", objMaiorT.Nome);
            Console.WriteLine("O local com MENOR gasto de uso {0}", objMenorC.Nome);

            Console.WriteLine("O local com MENOR tempo foi {0}", objMenorT.Nome);
            Console.WriteLine("O local com MAIOR gasto foi {0}", objMaiorC.Nome);
        }
    }
}
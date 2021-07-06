using System;
using System.Collections.Generic;
using System.IO;

namespace VendasEstabelecimento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dado.Produto> produtos = new List<Dado.Produto>();
            List<Dado.Venda> vendas = new List<Dado.Venda>();
            List<Dado.Estabelecimento> estabelecimentos = new List<Dado.Estabelecimento>();
            string[] palavras = null;


            StreamReader rd = new StreamReader(@"C:\Users\Paulo\Downloads\dataset.csv");

            List<string> list = new List<string>();

            string linha;
            int i = 0;
            int j = 0;
            int x = 0;

            rd.ReadLine();      //ler a primeira linha pra evitar ler o cabeçalho

            while (!rd.EndOfStream)
            {
                list.Add(linha = rd.ReadLine());
                palavras = linha.Split(',');

                Console.WriteLine("LINHAS LIDAS {0}", x);
                x++;

                int QuantidadeEstabelecimentos = 0;

                //ESTABELECIMENTO
                Dado.Estabelecimento objEstabelecimento = new Dado.Estabelecimento();

                bool ExisteNomeEstabelicimento = false;
                bool ExisteNomeLogradouro = false;
                bool ExisteCodigoLogradouro = false;
                bool ExisteComplemento = false;
                bool ExisteBairro = false;
                bool ExisteCodigoIBGE = false;
                bool ExisteNomeMunicipio = false;
                bool ExisteSiglaUF = false;
                bool ExisteCEP = false;
                bool ExisteLatitude = false;
                bool ExisteLongitude = false;
                bool ExisteIdEstabelecimento = false;

                objEstabelecimento.Latitude = 0;
                objEstabelecimento.Longitude = 0;// pode ser vazio

                //adiciona

                objEstabelecimento.IdEstabelecimento = long.Parse(palavras[8]);
                objEstabelecimento.NomeEstabelecimento = palavras[9];
                objEstabelecimento.NomeLogradouro = palavras[10];
                objEstabelecimento.CodigoLogradouro = int.Parse(palavras[11]);
                objEstabelecimento.ComplementoLogradouro = palavras[12];
                objEstabelecimento.Bairro = palavras[13];
                objEstabelecimento.CodigoIBGE = int.Parse(palavras[14]);
                objEstabelecimento.NomeMunicipio = palavras[15];
                objEstabelecimento.SiglaUF = palavras[16];
                objEstabelecimento.CodCEP = int.Parse(palavras[17]);

                if (palavras[18] == "" && palavras[19] == "")
                {

                    objEstabelecimento.Latitude = 0;
                    objEstabelecimento.Longitude = 0;// pode ser vazio

                    ExisteLatitude = estabelecimentos.Exists(x => x.Latitude == 0);
                    ExisteLongitude = estabelecimentos.Exists(x => x.Longitude == 0);
                }

                else
                {
                    objEstabelecimento.Latitude = double.Parse(palavras[18]);
                    objEstabelecimento.Longitude = double.Parse(palavras[19]);// pode ser vazio
                                                                              //verifica existência e retorna true


                }

                ExisteIdEstabelecimento = estabelecimentos.Exists(x => x.IdEstabelecimento == long.Parse(palavras[8]));
                ExisteNomeEstabelicimento = estabelecimentos.Exists(x => x.NomeEstabelecimento == palavras[9]);
                ExisteNomeLogradouro = estabelecimentos.Exists(x => x.NomeLogradouro == palavras[10]);
                ExisteCodigoLogradouro = estabelecimentos.Exists(x => x.CodigoLogradouro == int.Parse(palavras[11]));
                ExisteComplemento = estabelecimentos.Exists(x => x.ComplementoLogradouro == palavras[12]);
                ExisteBairro = estabelecimentos.Exists(x => x.Bairro == palavras[13]);
                ExisteCodigoIBGE = estabelecimentos.Exists(x => x.CodigoIBGE == int.Parse(palavras[14]));
                ExisteNomeMunicipio = estabelecimentos.Exists(x => x.NomeMunicipio == palavras[15]);
                ExisteSiglaUF = estabelecimentos.Exists(x => x.SiglaUF == palavras[16]);
                ExisteCEP = estabelecimentos.Exists(x => x.CodCEP == int.Parse(palavras[17]));



                if (ExisteIdEstabelecimento == true &&
                    ExisteNomeEstabelicimento == true &&
                    ExisteNomeLogradouro == true &&
                    ExisteCodigoLogradouro == true &&
                    ExisteComplemento == true &&
                    ExisteBairro == true &&
                    ExisteCodigoIBGE == true &&
                    ExisteNomeMunicipio == true &&
                    ExisteSiglaUF == true &&
                    ExisteCEP == true)
                {
                    // Console.WriteLine("ESTABELECIMIMENTO JÁ REGISTRADO");
                    j++;
                }
                else
                {
                    estabelecimentos.Add(objEstabelecimento);
                }

                QuantidadeEstabelecimentos++;

                //VENDAS 

                Dado.Venda objVenda = new Dado.Venda();

                bool ExisteData = false;
                bool ExisteValor = false;
                //adiciona
                objVenda.CodProduto = long.Parse(palavras[3]);
                objVenda.DataEmissao = palavras[1];


                //verifica e retorna true
                ExisteData = vendas.Exists(x => x.DataEmissao == palavras[1]);
                ExisteValor = vendas.Exists(x => x.Valor == (palavras[7]));


                vendas.Add(objVenda);

                // PRODUTOS

                Dado.Produto objProduto = new Dado.Produto();

                bool ExisteCODGNIT = false;
                bool ExisteCODNCM = false;
                bool ExisteCODPRODUTO = false;
                bool ExisteCODUNIDADE = false;
                bool ExisteDESCPRODUTO = false;
                bool ExisteIDESTABELECIMENTO = false;
                bool ExisteValorUnitario = false;

                //adiciona
                objProduto.CodGNIT = long.Parse(palavras[0]);
                objProduto.codProduto = long.Parse(palavras[3]);
                objProduto.codNCM = long.Parse(palavras[4]);
                objProduto.codUnidade = palavras[5];
                objProduto.DscProduto = palavras[6];

                objProduto.VlrUnitario = palavras[7];
                objProduto.IdEstabelecimento = long.Parse(palavras[8]);
                //verifica
                ExisteCODGNIT = produtos.Exists(x => x.CodGNIT == long.Parse(palavras[0]));
                ExisteCODNCM = produtos.Exists(x => x.codNCM == long.Parse(palavras[4]));
                ExisteCODPRODUTO = produtos.Exists(x => x.codProduto == long.Parse(palavras[3]));
                ExisteCODUNIDADE = produtos.Exists(x => x.codUnidade == palavras[5]);
                ExisteDESCPRODUTO = produtos.Exists(x => x.DscProduto == palavras[6]);
                ExisteIDESTABELECIMENTO = produtos.Exists(x => x.IdEstabelecimento == long.Parse(palavras[8]));


                ExisteValorUnitario = produtos.Exists(x => x.VlrUnitario == (palavras[7]));



                if (ExisteCODNCM == true && ExisteCODPRODUTO == true && ExisteCODUNIDADE == true && ExisteDESCPRODUTO
                    == true && ExisteValorUnitario == true)
                {

                    i++;
                }
                else
                {
                    produtos.Add(objProduto);
                }

            }

            Console.WriteLine("QUANTIDADE DE PRODUTOS REGISTRADOS {0}", produtos.Count);
            Console.WriteLine("QUANTIDADE DE ESTABELECIMENTOS REGISTRADOS {0}", estabelecimentos.Count);
            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE PRODUTOS DUPLICADOS {0}", i);
            Console.WriteLine("QUANTIDADE DE ESTABELECIMENTOS DUPLICADOS {0}", j);

        }
    }
}

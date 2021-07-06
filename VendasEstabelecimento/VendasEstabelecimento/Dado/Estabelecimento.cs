using System;
using System.Collections.Generic;
using System.Text;

namespace VendasEstabelecimento.Dado
{
    public class Estabelecimento
    {
        public long IdEstabelecimento { get; set; }
        public string NomeEstabelecimento { get; set; }
        public string NomeLogradouro { get; set; }
        public int CodigoLogradouro { get; set; }
        public string ComplementoLogradouro { get; set; }
        public string Bairro { get; set; }
        public int CodigoIBGE { get; set; }
        public string NomeMunicipio { get; set; }
        public string SiglaUF { get; set; }
        public int CodCEP { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }


    }


}

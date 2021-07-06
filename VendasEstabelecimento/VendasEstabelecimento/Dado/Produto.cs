using System;
using System.Collections.Generic;
using System.Text;

namespace VendasEstabelecimento.Dado
{
    public class Produto
    {

        public long CodGNIT { get; set; }
        public long codProduto { get; set; }
        public long codNCM { get; set; }
        public string codUnidade { get; set; }
        public string DscProduto { get; set; }
        public string VlrUnitario { get; set; }
        public long IdEstabelecimento { get; set; }

       
    }
}

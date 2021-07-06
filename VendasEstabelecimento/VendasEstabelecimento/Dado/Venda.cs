using System;
using System.Collections.Generic;
using System.Text;

namespace VendasEstabelecimento.Dado
{
    class Venda
    {
       
        public string DataEmissao { get; set; }
        public long CodProduto{ get; set; }
        public string Valor { get; set; }
        public int TipoPagamento { get; set; }

    }
}

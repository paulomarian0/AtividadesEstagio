using System;
using System.Collections.Generic;
using System.Text;

namespace VilaoEletrico
{
    public class DadoTarifaEConta
    {
        public double ValorTarifa { get; set; }
        public string Bandeira { get; set; }
        public double ICMS { get; set; }
        public double PIS { get; set; }
        public double COFINS { get; set; }
    }
}

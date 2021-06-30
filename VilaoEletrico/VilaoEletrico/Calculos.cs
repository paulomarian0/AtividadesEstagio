using System;
using System.Collections.Generic;
using System.Text;

namespace VilaoEletrico
{

    public class Calculos
    {
        public static ObjetoCasa MaiorConsumo(List<ObjetoCasa> ObjetosDaCasa)
        {
            ObjetoCasa maiorConsumo = null;

            foreach (ObjetoCasa item in ObjetosDaCasa)
            {
                if(maiorConsumo == null 
                    || (maiorConsumo.ConsumoWatts * maiorConsumo.TempoUsoDia * 30) < (item.ConsumoWatts * item.TempoUsoDia*30))
                {
                    maiorConsumo = item;
                }
            }

            return maiorConsumo;
        }

        public static ObjetoCasa MenorConsumo(List<ObjetoCasa> ObjetosDaCasa)
        {
            ObjetoCasa menorConsumo = null;

            foreach (ObjetoCasa item in ObjetosDaCasa)
            {
                if (menorConsumo == null
                    || (menorConsumo.ConsumoWatts * menorConsumo.TempoUsoDia * 30) > (item.ConsumoWatts * item.TempoUsoDia * 30))
                {
                    menorConsumo = item;
                }
            }

            return menorConsumo;
        }

        public static ObjetoCasa MaiorTempoDeUso(List<ObjetoCasa> ObjetosDaCasa)
        {
            ObjetoCasa maiorTempoDeUso = null;

            foreach (ObjetoCasa item in ObjetosDaCasa)
            {
                if (maiorTempoDeUso == null
                    || (item.TempoUsoDia) > (maiorTempoDeUso.TempoUsoDia))
                {
                    maiorTempoDeUso = item;
                }
            }

            return maiorTempoDeUso;
        }

        public static ObjetoCasa MenorTempoDeUso(List<ObjetoCasa> ObjetosDaCasa)
        {
            ObjetoCasa menorTempoDeUso = null;

            foreach (ObjetoCasa item in ObjetosDaCasa)
            {
                if (menorTempoDeUso == null ||
                    (item.TempoUsoDia) < (menorTempoDeUso.TempoUsoDia))
                {


                    menorTempoDeUso = item;
                }
            }

            return menorTempoDeUso;
        }

     
     
    }
}

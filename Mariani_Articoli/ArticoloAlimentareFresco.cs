using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Articoli
{
    internal class ArticoloAlimentareFresco : ArticoloAlimentare
    {
        private int _giorni;

        public int Giorni { get; set; }

        public ArticoloAlimentareFresco(int codice, string descrizione, double prezzo, bool tessera, int anno, int giorni) : base (codice, descrizione, prezzo, tessera, anno) { Giorni = giorni; }

        public override void Sconta()
        {
            int scontoDaApplicare = 10;

            for (int i = 0; i < _giorni; i++) 
            {
                scontoDaApplicare--;
                
                if (scontoDaApplicare == 0) { break; }
            }

            if (scontoDaApplicare > 0)
            {
                Prezzo = Prezzo - (((scontoDaApplicare) * Prezzo) / 100);
            }

            base.Sconta();
        }
    }
}

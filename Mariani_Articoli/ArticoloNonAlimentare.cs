using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Articoli
{
    internal class ArticoloNonAlimentare : Articolo
    {
        private string _materiale;
        private bool _riciclabile;

        public string Materiale { get; set; }

        public bool Riciclabile { get; set; }

        public ArticoloNonAlimentare(int codice, string descrizione, double prezzo, bool tessera, string matariale, bool riciclabile) : base (codice, descrizione, prezzo, tessera) { Materiale = matariale; Riciclabile = riciclabile; }

        public override void Sconta(double prezzo)
        {
            if (Riciclabile) 
            {
                Prezzo = prezzo - ((10 * prezzo) / 100);
            }
            
            base.Sconta(Prezzo);
        }
    }
}

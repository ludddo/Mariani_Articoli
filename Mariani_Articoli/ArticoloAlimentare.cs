using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Articoli
{
    internal class ArticoloAlimentare: Articolo
    {
        private int _anno;

        public int Anno { get; set; }

        public ArticoloAlimentare(int codice, string descrizione, double prezzo, bool tessera, int anno) : base(codice, descrizione, prezzo, tessera) { Anno = anno; }

        public override void Sconta()
        {
            if (Anno == DateTime.Now.Year && Tessera) 
            {
                Prezzo = Prezzo - ((25 * Prezzo) / 100);
            }
            if (Anno != DateTime.Now.Year && Tessera) 
            {
                Prezzo = Prezzo - ((5 * Prezzo) / 100);
            }
            if (Anno == DateTime.Now.Year && !Tessera) 
            {
                Prezzo = Prezzo - ((20 * Prezzo) / 100);
            }
        }
    }
}

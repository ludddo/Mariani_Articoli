using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Mariani_Articoli
{
    internal class Articolo
    {
        protected int _codice;
        protected string _descrizione;
        protected double _prezzo;
        protected bool _tessera;

        public int Codice { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public bool Tessera { get; set;}

        public Articolo(int codice, string descrizione, double prezzo, bool tessera)
        {
            Codice = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Tessera = tessera;
        }

        virtual public void Sconta()
        {
            if (Tessera)
            {
                Prezzo = Prezzo - ((5 * Prezzo) / 100);
            }
        }
    }
}

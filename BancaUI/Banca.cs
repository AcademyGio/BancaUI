using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banchetta;

namespace BancaUI
{
    class Banca
    {
        public event EventHandler ContoCreato;
        protected void OnContoCreato()
        {
            ContoCreato?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ContoEliminato;
        protected void OnContoEliminato()
        {
            ContoEliminato?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler OperazioneEffettuata;
        protected void OnOperazioneEffettuata()
        {
            OperazioneEffettuata?.Invoke(this, EventArgs.Empty);
        }

        public Conto CreaConto(string intestatario)
        {
            Conto c = Banchetta.Banca.CreaConto(intestatario);
            OnContoCreato();
            return c;
        }
        public void EliminaConto(Conto c)
        {
            Banchetta.Banca.EliminaConto(c);
            OnContoEliminato();
        }
        public List<Conto> ElencoConti
        {
            get
            {
                return Banchetta.Banca.ElencoConti(false);
            }
        }
        public void PrelevaDalConto(Conto conto, DateTime dataOperazione, decimal importo, string causale)
        {
            Banchetta.Banca.PrelevaDalConto(conto, dataOperazione, importo, causale);
            OnOperazioneEffettuata();
        }
        public void VersaSulConto(Conto conto, DateTime dataOperazione, decimal importo, string causale)
        {
            Banchetta.Banca.VersaSulConto(conto, dataOperazione, importo, causale);
            OnOperazioneEffettuata();
        }
        public List<Operazione> RecuperaOperazioni(Conto conto)
        {
            Banchetta.Banca.RecuperaOperazioni(conto);
            return conto.Operazioni;
        }
    }
}

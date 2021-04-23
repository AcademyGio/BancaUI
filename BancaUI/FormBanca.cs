using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banchetta;    // solo per classi Conto e Operazione

namespace BancaUI
{
    public partial class FormBanca : Form
    {
        // l'unica istanza della classe a cui FormBanc si riferirà
        Banca banca = new Banca();
        Conto _contoAttivo = null;

        public FormBanca()
        {
            InitializeComponent();

            // iscrizione a tutti gli eventi che mi interessano
            banca.ContoCreato += Banca_ContoCreato;
            banca.OperazioneEffettuata += Banca_OperazioneEffettuata;
            banca.ContoEliminato += Banca_ContoEliminato;
        }

        private void Banca_ContoEliminato(object sender, EventArgs e)
        {
            ImpostaContoAttivo(null);

            AggiornaElencoConti();
        }

        private void Banca_OperazioneEffettuata(object sender, EventArgs e)
        {
            AggiornaOperazioni();
        }

        private void ImpostaContoAttivo(Conto c)
        {
            _contoAttivo = c;
            GestisciPulsanti();
        }

        private void GestisciPulsanti()
        {
            buttonPreleva.Enabled = _contoAttivo != null;
            buttonVersa.Enabled = _contoAttivo != null;
            buttonEliminaConto.Enabled = _contoAttivo != null;
        }

        private void AggiornaOperazioni()
        {
            listBoxOperazioni.DataSource = banca.RecuperaOperazioni(_contoAttivo).ToList();
            labelSaldo.Text = _contoAttivo.Saldo.ToString("C");
        }

        private void AggiornaElencoConti()
        {
            listBoxConti.DataSource = banca.ElencoConti.ToList();
        }

        private void Banca_ContoCreato(object sender, EventArgs e)
        {
            AggiornaElencoConti();
        }

        private void buttonCreaConto_Click(object sender, EventArgs e)
        {
            try
            {
                Conto c = banca.CreaConto(textBoxIntestatario.Text);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBanca_Load(object sender, EventArgs e)
        {
            ImpostaContoAttivo(null);
            AggiornaElencoConti();
        }

        private void listBoxConti_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImpostaContoAttivo((Conto)listBoxConti.SelectedItem);
            AggiornaOperazioni();
        }

        private void buttonPreleva_Click(object sender, EventArgs e)
        {
            banca.PrelevaDalConto(_contoAttivo, DateTime.Today, numericUpDownImporto.Value, textBoxCausale.Text);
        }

        private void buttonVersa_Click(object sender, EventArgs e)
        {
            banca.VersaSulConto(_contoAttivo, DateTime.Today, numericUpDownImporto.Value, textBoxCausale.Text);
        }

        private void buttonEliminaConto_Click(object sender, EventArgs e)
        {
            try
            {
                banca.EliminaConto(_contoAttivo);
            }
            catch   // assumo che il problema sia nell'eliminazione del conto
            {
                MessageBox.Show("L'eliminazione del conto non è stata effettuata", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

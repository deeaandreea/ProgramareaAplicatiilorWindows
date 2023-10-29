using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Surdu_Bob_Andreea_1091
{
    public partial class FormMasa : Form
    {
        List<Masa> listaMese2;

        public FormMasa(List<Masa> listaMese)
        {
            InitializeComponent();

            infoUserControl1.Info = "Formular pentru gestiune mese.\n\n" +
                "Se face validare date cu error provider.";

            listaMese2 = listaMese;
            afisareListaMese();
        }

        private void afisareListaMese()
        {
            tbMese.Clear();
            foreach (Masa m in listaMese2)
            {
                tbMese.Text += m.ToString() + Environment.NewLine;
            }
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (tbCod.Text == "")
                errorProvider1.SetError(tbCod, "Introduceti codul!");
            else
                if (tbDescriere.Text == "")
                    errorProvider1.SetError(tbDescriere, "Introduceti descrierea!");
            else
                if (tbNrLocuri.Text == "")
                    errorProvider1.SetError(tbNrLocuri, "Introduceti numarul de locuri!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string cod = tbCod.Text;
                    string descriere = tbDescriere.Text;
                    int nrLocuri = Convert.ToInt32(tbNrLocuri.Text);
                    Masa m = new Masa(cod, descriere, nrLocuri);

                    listaMese2.Add(m);
                    afisareListaMese();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCod.Clear();
                    tbDescriere.Clear();
                    tbNrLocuri.Clear();
                }
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            tbCod.Clear();
            tbDescriere.Clear();
            tbNrLocuri.Clear();
        }
    }
}

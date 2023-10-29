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
    public partial class FormOspatar : Form
    {
        List<Ospatar> listaOspatari2;

        public FormOspatar(List<Ospatar> listaOspatari)
        {
            InitializeComponent();

            infoUserControl1.Info = "Formular pentru gestiune ospatari.\n\n" +
                "Se face validare date cu error provider.";

            listaOspatari2 = listaOspatari;
            afisareListaOspatari();
        }

        private void afisareListaOspatari()
        {
            tbOspatari.Clear();
            foreach (Ospatar o in listaOspatari2)
            {
                tbOspatari.Text += o.ToString() + Environment.NewLine;
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
                if (tbCNP.Text == "")
                    errorProvider1.SetError(tbCNP, "Introduceti CNP!");
            else
                if (tbNume.Text == "")
                    errorProvider1.SetError(tbNume, "Introduceti numele!");
            else
                if (tbPrenume.Text == "")
                    errorProvider1.SetError(tbPrenume, "Introduceti prenumele!");
            else
                if (dtDataAngajare.Text == "")
                    errorProvider1.SetError(dtDataAngajare, "Introduceti data angajarii!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string cod = tbCod.Text;
                    string CNP = tbCNP.Text;
                    string nume = tbNume.Text;
                    string prenume = tbPrenume.Text;
                    DateTime dataAng = Convert.ToDateTime(dtDataAngajare.Text);
                    Ospatar o = new Ospatar(cod, CNP, nume, prenume, dataAng);

                    listaOspatari2.Add(o);
                    afisareListaOspatari();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCod.Clear();
                    tbCNP.Clear();
                    tbNume.Clear();
                    tbPrenume.Clear();
                    dtDataAngajare.Text = "";
                }
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            tbCod.Clear();
            tbCNP.Clear();
            tbNume.Clear();
            tbPrenume.Clear();
            dtDataAngajare.Text = "";
        }
    }
}

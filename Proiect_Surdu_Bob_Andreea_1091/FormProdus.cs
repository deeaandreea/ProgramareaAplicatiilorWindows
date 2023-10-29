using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Proiect_Surdu_Bob_Andreea_1091
{
    public partial class FormProdus : Form
    {
        List<Produs> listaProduse2;

        public FormProdus(List<Produs> listaProduse)
        {
            InitializeComponent();

            infoUserControl1.Info = "Formular pentru gestiune produse in meniu.\n\n" +
                "Foloseste meniu contextual pentru:\n" +
                "  - Salvare/incarcare fisier text\n" + 
                "  - Serializare/deserializare fisier binar\n\n" +
                "Se face validare date cu error provider.";

            listaProduse2 = listaProduse;
            afisareListaProduse();
        }

        private void afisareListaProduse()
        {
            tbProduse.Clear();
            foreach (Produs prod in listaProduse2)
            {
                tbProduse.Text += prod.ToString() + Environment.NewLine;
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
                if (tbDenumire.Text == "")
                    errorProvider1.SetError(tbDenumire, "Introduceti denumirea!");
            else
                if (tbPret.Text == "")
                    errorProvider1.SetError(tbPret, "Introduceti pretul!");
            else
                if (tbStoc.Text == "")
                    errorProvider1.SetError(tbStoc, "Introduceti numele!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int cod = Convert.ToInt32(tbCod.Text);
                    string denumire = tbDenumire.Text;
                    double pret = Convert.ToDouble(tbPret.Text);
                    double stoc = Convert.ToDouble(tbStoc.Text);
                    Produs p = new Produs(cod, denumire, pret, stoc);

                    listaProduse2.Add(p);
                    afisareListaProduse();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCod.Clear();
                    tbDenumire.Clear();
                    tbPret.Clear();
                    tbStoc.Clear();
                }
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            tbCod.Clear();
            tbDenumire.Clear();
            tbPret.Clear();
            tbStoc.Clear();
        }

        private void salvareFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.WriteLine(tbProduse.Text);
                sw.Close();
            }
        }

        private void citireFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                tbProduse.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.dat)|*.dat";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);
                bf.Serialize(fs, listaProduse2);
                fs.Close();
            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.dat)|*.dat";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                listaProduse2 = (List<Produs>)bf.Deserialize(fs);
                afisareListaProduse();
                fs.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Surdu_Bob_Andreea_1091
{
    public partial class FormRezervare : Form
    {
        List<Rezervare> listaRezervari;
        List<Masa> listaMese;
        List<Ospatar> listaOspatari;
        List<Produs> listaProduse;
        Dictionary<Produs, int> produseComanda = new Dictionary<Produs, int>();

        int idxRezervare; // pentru cazul in care forma este folosita pentru editare

        private string connString;

        public FormRezervare(List<Rezervare> listaRezervari, 
            List<Masa> listaMese, List<Ospatar> listaOspatari, 
            List<Produs> listaProduse, int idxRezervare)
        {
            InitializeComponent();

            infoUserControl1.Info = "Formular pentru gestiune rezervari.\n\n" +
               "Pentru adaugarea produselor in comanda se face\n" +
               "drag & drop din lista cu Produse meniu.\n\n" +
               "Se face stocarea datelor intr-o baza de date.";

            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\..\\database\\Restaurant.accdb";

            this.listaRezervari = listaRezervari;
            this.listaMese = listaMese;
            this.listaOspatari = listaOspatari;
            this.listaProduse = listaProduse;
            this.idxRezervare = idxRezervare;

            afisareListaProduseMeniu();
            afisareListaMese();
            afisareListaOspatari();

            if (idxRezervare == -1) // pentru mod Adaugare
            {
                tbCodRezervare.Text = "R" + (Rezervare.idRezervareMax + 1);
            }
            else // pentru mod Modificare
            {
                tbCodRezervare.Text = listaRezervari[idxRezervare].CodRezervare;
                tbNumeClient.Text = listaRezervari[idxRezervare].Nume;
                dtDataRezervare.Text = listaRezervari[idxRezervare].DataRezervare.ToString();
                foreach (Masa masa in cbMasa.Items)
                {
                    if (masa.Cod == listaRezervari[idxRezervare].CodMasa)
                    {
                        cbMasa.SelectedItem = masa;
                        break;
                    }
                }
                foreach (Ospatar ospatar in cbOspatar.Items)
                {
                    if (ospatar.Cod == listaRezervari[idxRezervare].CodOspatar)
                    {
                        cbOspatar.SelectedItem = ospatar;
                        break;
                    }
                }
                if (listaRezervari[idxRezervare].ProduseComanda != null)
                {
                    foreach (KeyValuePair<Produs, int> item in listaRezervari[idxRezervare].ProduseComanda)
                    {
                        Produs prod = item.Key;
                        int nr = item.Value;
                        ListViewItem lvi2 = new ListViewItem(prod.Denumire);
                        lvi2.SubItems.Add(nr.ToString());
                        lvi2.Tag = prod;
                        lvProduseComanda.Items.Add(lvi2);
                        produseComanda.Add(prod, nr);
                    }
                    tbValoareComanda.Text = Convert.ToString(listaRezervari[idxRezervare].calculeazaValoare());
                }
            }
        }

        void afisareListaProduseMeniu()
        {
            foreach(Produs prod in listaProduse)
            {
                ListViewItem item = new ListViewItem(prod.Cod.ToString());
                item.SubItems.Add(prod.Denumire);
                item.SubItems.Add(prod.Pret.ToString());
                item.SubItems.Add(prod.Stoc.ToString());
                ListViewItem lvi = lvProduseMeniu.Items.Add(item);
                lvi.Tag = prod;
            }
        }

        void afisareListaMese()
        {
            foreach(Masa masa in listaMese)
            {
                cbMasa.Items.Add(masa);
            }
        }

        void afisareListaOspatari()
        {
            foreach (Ospatar ospatar in listaOspatari)
            {
                cbOspatar.Items.Add(ospatar);
            }
        }

        void adaugareRezervareDB()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                string codRezervare = tbCodRezervare.Text;
                conexiune.Open();
                comanda.Transaction = conexiune.BeginTransaction();
                comanda.Connection = conexiune;

                comanda.CommandText = "INSERT INTO Rezervari (cod_rezervare, data_rezervare, nume, cod_masa, cod_ospatar) VALUES(?,?,?,?,?)";
                comanda.Parameters.Add("cod_rezervare", OleDbType.VarChar).Value = codRezervare;
                comanda.Parameters.Add("data_rezervare", OleDbType.Date).Value = Convert.ToDateTime(dtDataRezervare.Text);
                comanda.Parameters.Add("nume", OleDbType.VarChar).Value = tbNumeClient.Text;
                comanda.Parameters.Add("cod_masa", OleDbType.VarChar).Value = listaMese[cbMasa.SelectedIndex].Cod;
                comanda.Parameters.Add("cod_ospatar", OleDbType.VarChar).Value = listaOspatari[cbOspatar.SelectedIndex].Cod;
                comanda.ExecuteNonQuery();

                comanda.CommandText = "INSERT INTO ProduseComanda (cod_rezervare, cod_produs, cantitate) VALUES(?,?,?)";
                foreach (ListViewItem lvi in lvProduseComanda.Items)
                {
                    Produs prod = (Produs)lvi.Tag;
                    comanda.Parameters.Clear();
                    comanda.Parameters.Add("cod_rezervare", OleDbType.VarChar).Value = codRezervare;
                    comanda.Parameters.Add("cod_produs", OleDbType.VarChar).Value = prod.Cod;
                    comanda.Parameters.Add("cantitate", OleDbType.Integer).Value = Convert.ToInt32(lvi.SubItems[1].Text);
                    comanda.ExecuteNonQuery();
                }
                comanda.Transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        void modificareRezervareDB()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                string codRezervare = tbCodRezervare.Text;
                conexiune.Open();
                comanda.Transaction = conexiune.BeginTransaction();
                comanda.Connection = conexiune;

                comanda.CommandText = "UPDATE rezervari SET" +
                    " data_rezervare='" + Convert.ToDateTime(dtDataRezervare.Text) +
                    "', nume='" + tbNumeClient.Text +
                    "', cod_masa='" + listaMese[cbMasa.SelectedIndex].Cod +
                    "', cod_ospatar='" + listaOspatari[cbOspatar.SelectedIndex].Cod +
                    "' WHERE cod_rezervare = '" + codRezervare + "'";
                comanda.ExecuteNonQuery();

                comanda.CommandText = "DELETE FROM ProduseComanda WHERE cod_rezervare = '" + codRezervare + "'";
                comanda.ExecuteNonQuery();

                comanda.CommandText = "INSERT INTO ProduseComanda (cod_rezervare, cod_produs, cantitate) VALUES(?,?,?)";
                foreach (ListViewItem lvi in lvProduseComanda.Items)
                {
                    Produs prod = (Produs)lvi.Tag;
                    comanda.Parameters.Clear();
                    comanda.Parameters.Add("cod_rezervare", OleDbType.VarChar).Value = codRezervare;
                    comanda.Parameters.Add("cod_produs", OleDbType.VarChar).Value = prod.Cod;
                    comanda.Parameters.Add("cantitate", OleDbType.Integer).Value = Convert.ToInt32(lvi.SubItems[1].Text);
                    comanda.ExecuteNonQuery();
                }
                comanda.Transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (tbNumeClient.Text == "")
            {
                errorProvider1.SetError(tbNumeClient, "Introduceti numele clientului!");
            }
            else if (cbMasa.Text == "")
            {
                errorProvider1.SetError(cbMasa, "Selectati masa rezervata");
            }
            else if (cbOspatar.Text == "")
            {
                // pentru mod modificare codul ospatarului este obligatoriu
                if (idxRezervare >= 0)
                {
                    errorProvider1.SetError(cbOspatar, "Selectati numele ospatarului");
                }
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string codRezervare = tbCodRezervare.Text;
                    string numeClient = tbNumeClient.Text;
                    DateTime dataRezervare = Convert.ToDateTime(dtDataRezervare.Text);
                    string codMasa = ((Masa)cbMasa.SelectedItem).Cod;
                    string codOspatar = ((Ospatar)cbOspatar.SelectedItem).Cod;
                    
                    if (idxRezervare == -1) // pentru mod Adaugare Rezervare
                    {
                        Rezervare rez = new Rezervare(codRezervare, dataRezervare, numeClient, codMasa, codOspatar, this.produseComanda);
                        this.listaRezervari.Add(rez);
                        adaugareRezervareDB();
                    }
                    else // pentru mod Modificare Rezervare
                    {
                        this.listaRezervari[idxRezervare].Nume = numeClient;
                        this.listaRezervari[idxRezervare].DataRezervare = dataRezervare;
                        this.listaRezervari[idxRezervare].CodMasa = codMasa;
                        this.listaRezervari[idxRezervare].CodOspatar = codOspatar;
                        this.listaRezervari[idxRezervare].ProduseComanda = produseComanda;
                        //this.listaRezervari[idxRezervare] = rez;
                        modificareRezervareDB();
                    }
                    
                    Rezervare.idRezervareMax++;
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCodRezervare.Clear();
                    tbNumeClient.Clear();
                    cbMasa.ResetText();
                    cbOspatar.ResetText();
                    lvProduseComanda.Items.Clear();
                    lvProduseMeniu.SelectedItems.Clear();
                    tbValoareComanda.Clear();
                }
            }
        }

        private void lvProduseMeniu_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (lvProduseMeniu.Items.Count > 0)
            {
                ListViewItem lvi = lvProduseMeniu.SelectedItems[0];
                Produs prod = (Produs)lvi.Tag;
                if (prod.Stoc == 0)
                {
                    MessageBox.Show("Nu mai avem " + prod.Denumire + "!", "Verificare stoc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lvProduseMeniu.DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }

        private void lvProduseComanda_DragEnter(object sender, DragEventArgs e)
        {
            if (lvProduseMeniu.SelectedItems.Count > 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lvProduseComanda_DragDrop(object sender, DragEventArgs e)
        {
            if (lvProduseMeniu.SelectedItems.Count == 0)
                return;
            
            ListViewItem lvi = lvProduseMeniu.SelectedItems[0];
            Produs p = (Produs)lvi.Tag;
            p.Stoc--;
            lvi.SubItems[3].Text = p.Stoc.ToString();

            if (produseComanda.ContainsKey(p))
            {
                produseComanda[p]++;
                foreach (ListViewItem item in lvProduseComanda.Items)
                {
                    Produs prod = (Produs)item.Tag;
                    if (prod.Cod == p.Cod)
                    {
                        item.SubItems[1].Text = produseComanda[p].ToString();
                    }
                } 
            }
            else
            {
                ListViewItem lvi2 = new ListViewItem(p.Denumire);
                lvi2.SubItems.Add("1");
                lvi2.Tag = p;
                lvProduseComanda.Items.Add(lvi2);
                produseComanda.Add(p, 1);
            }
            double valComanda = 0.0;
            if (tbValoareComanda.Text != "")
            {
                valComanda = Convert.ToDouble(tbValoareComanda.Text);
            }
            tbValoareComanda.Text = Convert.ToString(valComanda + p.Pret);
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

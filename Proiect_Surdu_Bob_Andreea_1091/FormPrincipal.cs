using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_Surdu_Bob_Andreea_1091
{
    public partial class FormPrincipal : Form
    {
        List<Produs> listaProduse = new List<Produs>();
        List<Ospatar> listaOspatari = new List<Ospatar>();
        List<Masa> listaMese = new List<Masa>();
        List<Rezervare> listaRezervari = new List<Rezervare>();

        TreeView treeViewRezervari = new TreeView();

        string connString;

        public FormPrincipal()
        {
            InitializeComponent();

            infoUserControl1.Info = "Formularul principal pentru gestiunea activitatii unui restaurant.\n\n" +
               "Contine un meniu principal de unde:\n" +
               "  - Se poate face imprimarea listei de rezervari cu prezentarea\n" +
               "    grafica a datelor de baza intr-un tabel.\n\n" +
               "  - Se poate face exportul datelor in fisier text sau xml.\n\n" +
               "Iesirea din formular se poate face cu Esc sau Alt+E.\n\n" +
               "Se face stocarea si regasirea datelor intr-o baza de date.";

            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\..\\database\\Restaurant.accdb";

            incarcareProduseDB();
            incarcareMeseDB();
            incarcareOspatariDB();
            incarcareRezervariDB();

            afisareListaRezervari();
        }

        private void incarcareProduse()
        {
            Produs prod1 = new Produs(1, "Ciorba", 11, 20);
            Produs prod2 = new Produs(2, "Pizza Prosciuto Funghi", 39, 3);
            Produs prod3 = new Produs(3, "Paste carbonara", 31, 10);
            this.listaProduse.Add(prod1);
            this.listaProduse.Add(prod2);
            this.listaProduse.Add(prod3);
        }

        private void incarcareMese()
        {
            Masa m1 = new Masa("M1", "Masa de la geam", 6);
            Masa m2 = new Masa("M2", "Masa cea mare", 12);
            Masa m3 = new Masa("M3", "Masa 1 de pe terasa", 4);
            Masa m4 = new Masa("M4", "Masa 2 de pe terasa", 4);
            this.listaMese.Add(m1);
            this.listaMese.Add(m2);
            this.listaMese.Add(m3);
            this.listaMese.Add(m4);
        }

        private void incarcareOspatari()
        {
            Ospatar o1 = new Ospatar("O1", "1234567890123", "Popescu", "Andrei", new DateTime(2022, 11, 1));
            Ospatar o2 = new Ospatar("O2", "2345678901234", "Georgescu", "Maria", new DateTime(2023, 1, 1));
            this.listaOspatari.Add(o1);
            this.listaOspatari.Add(o2);
        }

        private void incarcareRezervari()
        {
            Rezervare r1 = new Rezervare("R1", new DateTime(2023, 3, 25), "Ioana", "M1", "O1", null);
            Rezervare r2 = new Rezervare("R2", new DateTime(2023, 3, 26), "Marius", "M4", "O2", null);
            Rezervare r3 = new Rezervare("R3", new DateTime(2023, 3, 27), "Monica", "M3", "O1", null);
            this.listaRezervari.Add(r1);
            this.listaRezervari.Add(r2);
            this.listaRezervari.Add(r3);
            Rezervare.idRezervareMax = this.listaRezervari.Count;
        }

        private void incarcareProduseDB()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM produse";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    int cod = Convert.ToInt32(reader["cod"].ToString());
                    string denumire = reader["denumire"].ToString();
                    double pret = Convert.ToDouble(reader["pret"].ToString());
                    double stoc = Convert.ToDouble(reader["stoc"].ToString());
                    Produs produs = new Produs(cod, denumire, pret, stoc);
                    this.listaProduse.Add(produs);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                incarcareProduse();
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void incarcareMeseDB()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM mese";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    string cod = reader["cod"].ToString();
                    string descriere = reader["descriere"].ToString();
                    int nrLocuri = Convert.ToInt32(reader["nr_locuri"].ToString());
                    Masa masa = new Masa(cod, descriere, nrLocuri);
                    this.listaMese.Add(masa);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                incarcareMese();
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void incarcareOspatariDB()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM ospatari";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    string cod = reader["cod"].ToString();
                    string cnp = reader["cnp"].ToString();
                    string nume = reader["nume"].ToString();
                    string prenume = reader["prenume"].ToString();
                    DateTime dataAngajare = Convert.ToDateTime(reader["data_angajare"].ToString());
                    Ospatar ospatar = new Ospatar(cod, cnp, nume, prenume, dataAngajare);
                    this.listaOspatari.Add(ospatar);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                incarcareOspatari();
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void incarcareRezervariDB()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            OleDbCommand comanda2 = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM Rezervari";
                comanda2.Connection = conexiune;
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    string cod = reader["cod_rezervare"].ToString();
                    DateTime dataRezervare = Convert.ToDateTime(reader["data_rezervare"].ToString());
                    string nume = reader["nume"].ToString();
                    string codMasa = reader["cod_masa"].ToString();
                    string codOspatar = reader["cod_ospatar"].ToString();
                    Rezervare rezervare = new Rezervare(cod, dataRezervare, nume, codMasa, codOspatar, null);

                    // citire produse din comanda corespunzatoare rezervarii
                    rezervare.ProduseComanda = new Dictionary<Produs, int>();
                    comanda2.CommandText = "SELECT * FROM ProduseComanda WHERE cod_rezervare = '" + cod + "'";
                    OleDbDataReader reader2 = comanda2.ExecuteReader();
                    while (reader2.Read())
                    {
                        int codProdus = Convert.ToInt32(reader2["cod_produs"].ToString());
                        int cantitate = Convert.ToInt32(reader2["cantitate"].ToString());
                        foreach(Produs prod in this.listaProduse)
                        {
                            if (prod.Cod == codProdus)
                            {
                                rezervare.ProduseComanda.Add(prod, cantitate);
                                break;
                            }
                        }
                    }
                    reader2.Close();

                    listaRezervari.Add(rezervare);
                    Rezervare.idRezervareMax = listaRezervari.Count;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                incarcareRezervari();
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void afisareListaRezervari()
        {
            lvRezervari.Items.Clear();
            foreach (Rezervare rez in listaRezervari)
            {
                ListViewItem item = new ListViewItem(rez.CodRezervare);
                item.SubItems.Add(rez.DataRezervare.ToString("dd/MM/yyyy")); //"dd MMMM yyyy"
                item.SubItems.Add(rez.Nume);
                //item.SubItems.Add(rez.CodMasa);
                foreach (Masa masa in listaMese)
                {
                    if (rez.CodMasa.Equals(masa.Cod))
                    {
                        item.SubItems.Add(masa.Descriere);
                        break;
                    }
                }
                lvRezervari.Items.Add(item);
            }
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestiuneMeniuri_Click(object sender, EventArgs e)
        {
            FormProdus frm = new FormProdus(listaProduse);
            frm.Show();
        }

        private void btnGestiuneOspatari_Click(object sender, EventArgs e)
        {
            FormOspatar frm = new FormOspatar(listaOspatari);
            frm.Show();
        }

        private void btnGestiuneMese_Click(object sender, EventArgs e)
        {
            FormMasa frm = new FormMasa(listaMese);
            frm.Show();
        }

        private void fisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Export rezervari in fișier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName);

                foreach (Rezervare rez in listaRezervari)
                {
                    writer.WriteLine("Rezervare " + rez.CodRezervare + ", din data " + rez.DataRezervare);
                }
                writer.Close();
            }
        }

        private void populareTreeView()
        {
            TreeNode parinte = new TreeNode("Rezervari");
            this.treeViewRezervari.Nodes.Add(parinte);

            foreach (Rezervare rezervare in this.listaRezervari)
            {
                TreeNode copil = new TreeNode(rezervare.CodRezervare);
                parinte.Nodes.Add(copil);

                TreeNode nepot1 = new TreeNode(rezervare.DataRezervare.ToString());
                copil.Nodes.Add(nepot1);
                TreeNode nepot2 = new TreeNode(rezervare.CodMasa);
                copil.Nodes.Add(nepot2);
                TreeNode nepot = new TreeNode();
                if (rezervare.DataRezervare.DayOfWeek == DayOfWeek.Saturday || rezervare.DataRezervare.DayOfWeek == DayOfWeek.Sunday)
                    nepot.Text = "weekend";
                else
                    nepot.Text = "in cursul saptamanii";
                copil.Nodes.Add(nepot);
            }
            //treeViewRezervari.ExpandAll();
        }

        private void fisierXmlToolStripMenuItem_Click0(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Export rezervari in fișier xml";
            sfd.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                populareTreeView();

                MemoryStream memStream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();

                foreach (TreeNode parinte in treeViewRezervari.Nodes)
                {
                    writer.WriteStartElement(parinte.Text);
                    foreach (TreeNode copil in parinte.Nodes)
                    {
                        writer.WriteStartElement("Rezervare");
                        writer.WriteAttributeString("CodRezervare", copil.Text);
                        foreach (TreeNode nepot in copil.Nodes)
                        {
                            writer.WriteStartElement(nepot.Text);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndDocument();
                writer.Close();

                string str = Encoding.UTF8.GetString(memStream.ToArray());
                memStream.Close();

                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(str);
                sw.Close();
            }
        }

        private void fisierXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Export rezervari in fișier xml";
            sfd.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MemoryStream memStream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();

                writer.WriteStartElement("Rezervari");
                foreach (Rezervare rezervare in this.listaRezervari)
                {
                    writer.WriteStartElement("Rezervare");
                    writer.WriteAttributeString("Cod", rezervare.CodRezervare);

                    if (rezervare.DataRezervare.DayOfWeek == DayOfWeek.Saturday || rezervare.DataRezervare.DayOfWeek == DayOfWeek.Sunday)
                    {
                        writer.WriteAttributeString("Perioada", "weekend");
                    }
                    else
                    {
                        writer.WriteAttributeString("Perioada", "in cursul saptamanii");
                    }

                        writer.WriteStartElement("Data");
                        writer.WriteValue(rezervare.DataRezervare);
                        writer.WriteEndElement();
                        writer.WriteStartElement("CodMasa");
                        writer.WriteValue(rezervare.CodMasa);
                        writer.WriteEndElement();

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                string str = Encoding.UTF8.GetString(memStream.ToArray());
                memStream.Close();

                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(str);
                sw.Close();
            }
        }

        private void tiparireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog1 = new PageSetupDialog();
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;

            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;

                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontTitlu = new Font("Calibri", 18, FontStyle.Bold);
            Font fontHeader = new Font("Calibri", 14, FontStyle.Bold);
            Font font = new Font("Calibri", 14);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);
            Brush brush2 = Brushes.Blue;
            SolidBrush brush3 = new SolidBrush(Color.LightGoldenrodYellow);

            PageSettings settings = ((PrintDocument)sender).DefaultPageSettings;
            var totalDrawableW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;
            if (settings.Landscape)
            {
                var temp = totalDrawableW;
                totalDrawableW = totalDrawableH;
                totalDrawableH = temp;
            }
            int cellWidth = totalDrawableW / 4;
            int cellHeight = 30;
            int x = settings.Margins.Left;
            int y = 70;
            graphics.DrawString("Lista Rezervari", fontTitlu, brush2, x + 70, y);

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream imgStream = myAssembly.GetManifestResourceStream("Proiect_Surdu_Bob_Andreea_1091.restaurant.png");
            Bitmap img = new Bitmap(imgStream);
            //Image imageFile = Image.FromFile(@"C:\andreea\projects\PAW\Proiect_Surdu_Bob_Andreea_1091\restaurant.png");
            Graphics newGraphics = Graphics.FromImage(img);
            newGraphics.FillRectangle(new SolidBrush(Color.Black), 100, 50, 100, 100);
            e.Graphics.DrawImage(img, new PointF(x, y));
            newGraphics.Dispose();

            y = 130;
            graphics.FillRectangle(brush3, new Rectangle(x, y, totalDrawableW, cellHeight));
            graphics.DrawString("Cod rezervare", fontHeader, brush2, x, y);
            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawString("Data rezervare", fontHeader, brush2, x + cellWidth, y);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
            graphics.DrawString("Nume", fontHeader, brush2, x + 2 * cellWidth, y);
            graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);
            graphics.DrawString("Masa", fontHeader, brush2, x + 3 * cellWidth, y);
            graphics.DrawRectangle(pen, x + 3 * cellWidth, y, cellWidth, cellHeight);

            y += cellHeight;
            foreach (Rezervare rez in listaRezervari)
            {
                graphics.DrawString(rez.CodRezervare, font, brush2, x, y);
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                graphics.DrawString(rez.DataRezervare.ToString("dd/MM/yyyy"), font, brush2, x + cellWidth, y);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
                graphics.DrawString(rez.Nume, font, brush2, x + 2 * cellWidth, y);
                graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);
                string descriereMasa = rez.CodMasa;
                foreach (Masa masa in listaMese)
                {
                    if (rez.CodMasa.Equals(masa.Cod))
                    {
                        descriereMasa = masa.Descriere;
                        break;
                    }
                }
                graphics.DrawString(descriereMasa, font, brush2, x + 3 * cellWidth, y);
                graphics.DrawRectangle(pen, x + 3 * cellWidth, y, cellWidth, cellHeight);

                y += cellHeight;
            }
        }

        private void btnAdaugaRezervare_Click(object sender, EventArgs e)
        {
            FormRezervare form = new FormRezervare(listaRezervari, listaMese, listaOspatari, listaProduse, -1);
            if (form.ShowDialog() == DialogResult.OK)
            {
                afisareListaRezervari();
            }
        }

        private void btnModificaRezervare_Click(object sender, EventArgs e)
        {
            if (lvRezervari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati o rezervare pentru modificare!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idxRezervare = lvRezervari.SelectedIndices[0];
            FormRezervare form = new FormRezervare(listaRezervari, listaMese, listaOspatari, listaProduse, idxRezervare);
            form.Text = "Modifica Rezervare";
            if (form.ShowDialog() == DialogResult.OK)
            {
                afisareListaRezervari();
            }
        }

        private void btnStergeRezervare_Click(object sender, EventArgs e)
        {
            stergereRezervare();
            ListViewItem item = lvRezervari.SelectedItems[0];
            lvRezervari.Items.Remove(item);
        }

        private void stergereRezervare()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                Rezervare rezervare = this.listaRezervari[lvRezervari.SelectedItems[0].Index];
                comanda.Connection = conexiune;
                comanda.CommandText = "DELETE FROM Rezervari WHERE cod_rezervare = '" + rezervare.CodRezervare + "'";
                comanda.ExecuteNonQuery();
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

        private void lvRezervari_DoubleClick(object sender, EventArgs e)
        {
            btnModificaRezervare_Click(sender, e);
        }

        private void lvRezervari_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Alt && e.KeyCode == Keys.E) || e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                e.SuppressKeyPress = true;
            }
        }
    }
}


namespace Proiect_Surdu_Bob_Andreea_1091
{
    partial class FormRezervare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbValoareComanda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvProduseComanda = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.cbOspatar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMasa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataRezervare = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodRezervare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvProduseMeniu = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRenunta = new System.Windows.Forms.Button();
            this.infoUserControl1 = new InfoUserControl.InfoUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbValoareComanda);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lvProduseComanda);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbOspatar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbMasa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNumeClient);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtDataRezervare);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbCodRezervare);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 417);
            this.panel1.TabIndex = 16;
            // 
            // tbValoareComanda
            // 
            this.tbValoareComanda.Location = new System.Drawing.Point(159, 341);
            this.tbValoareComanda.Name = "tbValoareComanda";
            this.tbValoareComanda.Size = new System.Drawing.Size(100, 20);
            this.tbValoareComanda.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Valoare comanda";
            // 
            // lvProduseComanda
            // 
            this.lvProduseComanda.AllowDrop = true;
            this.lvProduseComanda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProduseComanda.GridLines = true;
            this.lvProduseComanda.HideSelection = false;
            this.lvProduseComanda.Location = new System.Drawing.Point(159, 227);
            this.lvProduseComanda.Name = "lvProduseComanda";
            this.lvProduseComanda.Size = new System.Drawing.Size(231, 97);
            this.lvProduseComanda.TabIndex = 22;
            this.lvProduseComanda.UseCompatibleStateImageBehavior = false;
            this.lvProduseComanda.View = System.Windows.Forms.View.Details;
            this.lvProduseComanda.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvProduseComanda_DragDrop);
            this.lvProduseComanda.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvProduseComanda_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produs";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantitate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Produse comanda";
            // 
            // cbOspatar
            // 
            this.cbOspatar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOspatar.FormattingEnabled = true;
            this.cbOspatar.Location = new System.Drawing.Point(159, 185);
            this.cbOspatar.Name = "cbOspatar";
            this.cbOspatar.Size = new System.Drawing.Size(231, 21);
            this.cbOspatar.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ospatar";
            // 
            // cbMasa
            // 
            this.cbMasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMasa.FormattingEnabled = true;
            this.cbMasa.Location = new System.Drawing.Point(159, 145);
            this.cbMasa.Name = "cbMasa";
            this.cbMasa.Size = new System.Drawing.Size(231, 21);
            this.cbMasa.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Masa";
            // 
            // tbNumeClient
            // 
            this.tbNumeClient.AllowDrop = true;
            this.tbNumeClient.Location = new System.Drawing.Point(159, 105);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.Size = new System.Drawing.Size(231, 20);
            this.tbNumeClient.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nume client";
            // 
            // dtDataRezervare
            // 
            this.dtDataRezervare.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataRezervare.Location = new System.Drawing.Point(159, 65);
            this.dtDataRezervare.Name = "dtDataRezervare";
            this.dtDataRezervare.Size = new System.Drawing.Size(231, 20);
            this.dtDataRezervare.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // tbCodRezervare
            // 
            this.tbCodRezervare.Enabled = false;
            this.tbCodRezervare.Location = new System.Drawing.Point(159, 25);
            this.tbCodRezervare.Name = "tbCodRezervare";
            this.tbCodRezervare.Size = new System.Drawing.Size(231, 20);
            this.tbCodRezervare.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod rezervare";
            // 
            // lvProduseMeniu
            // 
            this.lvProduseMeniu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvProduseMeniu.FullRowSelect = true;
            this.lvProduseMeniu.GridLines = true;
            this.lvProduseMeniu.HideSelection = false;
            this.lvProduseMeniu.Location = new System.Drawing.Point(470, 192);
            this.lvProduseMeniu.Name = "lvProduseMeniu";
            this.lvProduseMeniu.Size = new System.Drawing.Size(298, 183);
            this.lvProduseMeniu.TabIndex = 17;
            this.lvProduseMeniu.UseCompatibleStateImageBehavior = false;
            this.lvProduseMeniu.View = System.Windows.Forms.View.Details;
            this.lvProduseMeniu.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvProduseMeniu_ItemDrag);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cod";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Denumire";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pret";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Stoc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Produse meniu";
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(470, 405);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 23);
            this.btnSalvare.TabIndex = 19;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(569, 405);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(75, 23);
            this.btnRenunta.TabIndex = 20;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // infoUserControl1
            // 
            this.infoUserControl1.Location = new System.Drawing.Point(721, 12);
            this.infoUserControl1.Name = "infoUserControl1";
            this.infoUserControl1.Size = new System.Drawing.Size(46, 43);
            this.infoUserControl1.TabIndex = 21;
            // 
            // FormRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoUserControl1);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvProduseMeniu);
            this.Controls.Add(this.panel1);
            this.Name = "FormRezervare";
            this.Text = "Adauga Rezervare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataRezervare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodRezervare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvProduseComanda;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOspatar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMasa;
        private System.Windows.Forms.ListView lvProduseMeniu;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbValoareComanda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRenunta;
        private InfoUserControl.InfoUserControl infoUserControl1;
    }
}
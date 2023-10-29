
namespace Proiect_Surdu_Bob_Andreea_1091
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelImg = new System.Windows.Forms.Panel();
            this.btnGestiuneMese = new System.Windows.Forms.Button();
            this.btnStergeRezervare = new System.Windows.Forms.Button();
            this.btnModificaRezervare = new System.Windows.Forms.Button();
            this.btnAdaugaRezervare = new System.Windows.Forms.Button();
            this.btnGestiuneMeniuri = new System.Windows.Forms.Button();
            this.btnGestiuneOspatari = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiparireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInchide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvRezervari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infoUserControl1 = new InfoUserControl.InfoUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.panelImg);
            this.panel1.Controls.Add(this.btnGestiuneMese);
            this.panel1.Controls.Add(this.btnStergeRezervare);
            this.panel1.Controls.Add(this.btnModificaRezervare);
            this.panel1.Controls.Add(this.btnAdaugaRezervare);
            this.panel1.Controls.Add(this.btnGestiuneMeniuri);
            this.panel1.Controls.Add(this.btnGestiuneOspatari);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 497);
            this.panel1.TabIndex = 7;
            // 
            // panelImg
            // 
            this.panelImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImg.BackgroundImage")));
            this.panelImg.Location = new System.Drawing.Point(17, 3);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(94, 93);
            this.panelImg.TabIndex = 11;
            // 
            // btnGestiuneMese
            // 
            this.btnGestiuneMese.BackColor = System.Drawing.Color.Linen;
            this.btnGestiuneMese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestiuneMese.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGestiuneMese.Location = new System.Drawing.Point(17, 208);
            this.btnGestiuneMese.Name = "btnGestiuneMese";
            this.btnGestiuneMese.Size = new System.Drawing.Size(140, 50);
            this.btnGestiuneMese.TabIndex = 10;
            this.btnGestiuneMese.Text = "Gestiune Mese";
            this.btnGestiuneMese.UseVisualStyleBackColor = false;
            this.btnGestiuneMese.Click += new System.EventHandler(this.btnGestiuneMese_Click);
            // 
            // btnStergeRezervare
            // 
            this.btnStergeRezervare.BackColor = System.Drawing.Color.Linen;
            this.btnStergeRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeRezervare.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStergeRezervare.Location = new System.Drawing.Point(17, 396);
            this.btnStergeRezervare.Name = "btnStergeRezervare";
            this.btnStergeRezervare.Size = new System.Drawing.Size(140, 50);
            this.btnStergeRezervare.TabIndex = 9;
            this.btnStergeRezervare.Text = "Sterge Rezervare";
            this.btnStergeRezervare.UseVisualStyleBackColor = false;
            this.btnStergeRezervare.Click += new System.EventHandler(this.btnStergeRezervare_Click);
            // 
            // btnModificaRezervare
            // 
            this.btnModificaRezervare.BackColor = System.Drawing.Color.Linen;
            this.btnModificaRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaRezervare.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnModificaRezervare.Location = new System.Drawing.Point(17, 340);
            this.btnModificaRezervare.Name = "btnModificaRezervare";
            this.btnModificaRezervare.Size = new System.Drawing.Size(140, 50);
            this.btnModificaRezervare.TabIndex = 8;
            this.btnModificaRezervare.Text = "Modifica Rezervare";
            this.btnModificaRezervare.UseVisualStyleBackColor = false;
            this.btnModificaRezervare.Click += new System.EventHandler(this.btnModificaRezervare_Click);
            // 
            // btnAdaugaRezervare
            // 
            this.btnAdaugaRezervare.BackColor = System.Drawing.Color.Linen;
            this.btnAdaugaRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaRezervare.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdaugaRezervare.Location = new System.Drawing.Point(17, 284);
            this.btnAdaugaRezervare.Name = "btnAdaugaRezervare";
            this.btnAdaugaRezervare.Size = new System.Drawing.Size(140, 50);
            this.btnAdaugaRezervare.TabIndex = 8;
            this.btnAdaugaRezervare.Text = "Adauga Rezervare";
            this.btnAdaugaRezervare.UseVisualStyleBackColor = false;
            this.btnAdaugaRezervare.Click += new System.EventHandler(this.btnAdaugaRezervare_Click);
            // 
            // btnGestiuneMeniuri
            // 
            this.btnGestiuneMeniuri.BackColor = System.Drawing.Color.Linen;
            this.btnGestiuneMeniuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestiuneMeniuri.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGestiuneMeniuri.Location = new System.Drawing.Point(17, 96);
            this.btnGestiuneMeniuri.Name = "btnGestiuneMeniuri";
            this.btnGestiuneMeniuri.Size = new System.Drawing.Size(140, 50);
            this.btnGestiuneMeniuri.TabIndex = 0;
            this.btnGestiuneMeniuri.Text = "Gestiune Meniuri";
            this.btnGestiuneMeniuri.UseVisualStyleBackColor = false;
            this.btnGestiuneMeniuri.Click += new System.EventHandler(this.btnGestiuneMeniuri_Click);
            // 
            // btnGestiuneOspatari
            // 
            this.btnGestiuneOspatari.BackColor = System.Drawing.Color.Linen;
            this.btnGestiuneOspatari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestiuneOspatari.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGestiuneOspatari.Location = new System.Drawing.Point(17, 152);
            this.btnGestiuneOspatari.Name = "btnGestiuneOspatari";
            this.btnGestiuneOspatari.Size = new System.Drawing.Size(140, 50);
            this.btnGestiuneOspatari.TabIndex = 2;
            this.btnGestiuneOspatari.Text = "Gestiune Ospatari";
            this.btnGestiuneOspatari.UseVisualStyleBackColor = false;
            this.btnGestiuneOspatari.Click += new System.EventHandler(this.btnGestiuneOspatari_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.infoUserControl1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 45);
            this.panel2.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportInFisierToolStripMenuItem,
            this.tiparireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(193, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportInFisierToolStripMenuItem
            // 
            this.exportInFisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierTextToolStripMenuItem,
            this.fisierXmlToolStripMenuItem});
            this.exportInFisierToolStripMenuItem.Name = "exportInFisierToolStripMenuItem";
            this.exportInFisierToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.exportInFisierToolStripMenuItem.Text = "Export in &Fisier";
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            this.fisierTextToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fisierTextToolStripMenuItem.Text = "Fisier &Text";
            this.fisierTextToolStripMenuItem.Click += new System.EventHandler(this.fisierTextToolStripMenuItem_Click);
            // 
            // fisierXmlToolStripMenuItem
            // 
            this.fisierXmlToolStripMenuItem.Name = "fisierXmlToolStripMenuItem";
            this.fisierXmlToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fisierXmlToolStripMenuItem.Text = "Fisier &Xml";
            this.fisierXmlToolStripMenuItem.Click += new System.EventHandler(this.fisierXmlToolStripMenuItem_Click);
            // 
            // tiparireToolStripMenuItem
            // 
            this.tiparireToolStripMenuItem.Name = "tiparireToolStripMenuItem";
            this.tiparireToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tiparireToolStripMenuItem.Text = "&Tiparire";
            this.tiparireToolStripMenuItem.Click += new System.EventHandler(this.tiparireToolStripMenuItem_Click);
            // 
            // btnInchide
            // 
            this.btnInchide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInchide.BackColor = System.Drawing.Color.Linen;
            this.btnInchide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInchide.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnInchide.Location = new System.Drawing.Point(794, 457);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(75, 30);
            this.btnInchide.TabIndex = 12;
            this.btnInchide.Text = "Inchide";
            this.btnInchide.UseVisualStyleBackColor = false;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(195, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista Rezervari";
            // 
            // lvRezervari
            // 
            this.lvRezervari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRezervari.FullRowSelect = true;
            this.lvRezervari.GridLines = true;
            this.lvRezervari.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRezervari.HideSelection = false;
            this.lvRezervari.Location = new System.Drawing.Point(198, 96);
            this.lvRezervari.MultiSelect = false;
            this.lvRezervari.Name = "lvRezervari";
            this.lvRezervari.Size = new System.Drawing.Size(671, 355);
            this.lvRezervari.TabIndex = 18;
            this.lvRezervari.UseCompatibleStateImageBehavior = false;
            this.lvRezervari.View = System.Windows.Forms.View.Details;
            this.lvRezervari.DoubleClick += new System.EventHandler(this.lvRezervari_DoubleClick);
            this.lvRezervari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvRezervari_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod rezervare";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data rezervare";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nume";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Masa";
            this.columnHeader4.Width = 300;
            // 
            // infoUserControl1
            // 
            this.infoUserControl1.Location = new System.Drawing.Point(656, -1);
            this.infoUserControl1.Name = "infoUserControl1";
            this.infoUserControl1.Size = new System.Drawing.Size(46, 43);
            this.infoUserControl1.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 497);
            this.Controls.Add(this.lvRezervari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "Activitate Restaurant";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStergeRezervare;
        private System.Windows.Forms.Button btnModificaRezervare;
        private System.Windows.Forms.Button btnAdaugaRezervare;
        private System.Windows.Forms.Button btnGestiuneMeniuri;
        private System.Windows.Forms.Button btnGestiuneOspatari;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportInFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiparireToolStripMenuItem;
        private System.Windows.Forms.Button btnInchide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestiuneMese;
        private System.Windows.Forms.ListView lvRezervari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panelImg;
        private InfoUserControl.InfoUserControl infoUserControl1;
    }
}


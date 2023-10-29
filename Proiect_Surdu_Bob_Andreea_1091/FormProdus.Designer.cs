
namespace Proiect_Surdu_Bob_Andreea_1091
{
    partial class FormProdus
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
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.tbStoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProduse = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvareFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInchide = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.infoUserControl1 = new InfoUserControl.InfoUserControl();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRenunta);
            this.panel1.Controls.Add(this.btnSalveaza);
            this.panel1.Controls.Add(this.tbStoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPret);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbDenumire);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbCod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 282);
            this.panel1.TabIndex = 2;
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(83, 243);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(75, 23);
            this.btnRenunta.TabIndex = 9;
            this.btnRenunta.Text = "&Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(164, 243);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "&Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // tbStoc
            // 
            this.tbStoc.Location = new System.Drawing.Point(103, 134);
            this.tbStoc.Name = "tbStoc";
            this.tbStoc.Size = new System.Drawing.Size(136, 20);
            this.tbStoc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stoc";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(103, 92);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(136, 20);
            this.tbPret.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pret";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(103, 51);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(136, 20);
            this.tbDenumire.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Denumire";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(103, 14);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(136, 20);
            this.tbCod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adauga Produs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(296, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lista Produse";
            // 
            // tbProduse
            // 
            this.tbProduse.BackColor = System.Drawing.Color.Linen;
            this.tbProduse.ContextMenuStrip = this.contextMenuStrip1;
            this.tbProduse.Location = new System.Drawing.Point(299, 35);
            this.tbProduse.Multiline = true;
            this.tbProduse.Name = "tbProduse";
            this.tbProduse.Size = new System.Drawing.Size(489, 282);
            this.tbProduse.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierTextToolStripMenuItem,
            this.citireFisierTextToolStripMenuItem,
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 92);
            // 
            // salvareFisierTextToolStripMenuItem
            // 
            this.salvareFisierTextToolStripMenuItem.Name = "salvareFisierTextToolStripMenuItem";
            this.salvareFisierTextToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.salvareFisierTextToolStripMenuItem.Text = "Salvare &Fisier Text";
            this.salvareFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salvareFisierTextToolStripMenuItem_Click);
            // 
            // citireFisierTextToolStripMenuItem
            // 
            this.citireFisierTextToolStripMenuItem.Name = "citireFisierTextToolStripMenuItem";
            this.citireFisierTextToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.citireFisierTextToolStripMenuItem.Text = "&Citire Fisier Text";
            this.citireFisierTextToolStripMenuItem.Click += new System.EventHandler(this.citireFisierTextToolStripMenuItem_Click);
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.serializareToolStripMenuItem.Text = "&Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deserializareToolStripMenuItem.Text = "&Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // btnInchide
            // 
            this.btnInchide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInchide.BackColor = System.Drawing.Color.Linen;
            this.btnInchide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInchide.ForeColor = System.Drawing.Color.Sienna;
            this.btnInchide.Location = new System.Drawing.Point(713, 335);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(75, 30);
            this.btnInchide.TabIndex = 17;
            this.btnInchide.Text = "Inchide";
            this.btnInchide.UseVisualStyleBackColor = false;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // infoUserControl1
            // 
            this.infoUserControl1.Location = new System.Drawing.Point(12, 322);
            this.infoUserControl1.Name = "infoUserControl1";
            this.infoUserControl1.Size = new System.Drawing.Size(46, 43);
            this.infoUserControl1.TabIndex = 18;
            // 
            // FormProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.infoUserControl1);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.tbProduse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "FormProdus";
            this.Text = "Gestiune Meniuri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.TextBox tbStoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProduse;
        private System.Windows.Forms.Button btnInchide;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private InfoUserControl.InfoUserControl infoUserControl1;
    }
}
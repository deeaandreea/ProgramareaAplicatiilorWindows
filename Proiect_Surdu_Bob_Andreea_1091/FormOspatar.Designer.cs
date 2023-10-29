
namespace Proiect_Surdu_Bob_Andreea_1091
{
    partial class FormOspatar
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
            this.btnInchide = new System.Windows.Forms.Button();
            this.tbOspatari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtDataAngajare = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.infoUserControl1 = new InfoUserControl.InfoUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.btnInchide.TabIndex = 22;
            this.btnInchide.Text = "Inchide";
            this.btnInchide.UseVisualStyleBackColor = false;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // tbOspatari
            // 
            this.tbOspatari.BackColor = System.Drawing.Color.Linen;
            this.tbOspatari.Location = new System.Drawing.Point(299, 35);
            this.tbOspatari.Multiline = true;
            this.tbOspatari.Name = "tbOspatari";
            this.tbOspatari.Size = new System.Drawing.Size(489, 282);
            this.tbOspatari.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(296, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lista Ospatari";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adauga Ospatar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtDataAngajare);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnRenunta);
            this.panel1.Controls.Add(this.btnSalveaza);
            this.panel1.Controls.Add(this.tbPrenume);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNume);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbCNP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbCod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 282);
            this.panel1.TabIndex = 18;
            // 
            // dtDataAngajare
            // 
            this.dtDataAngajare.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataAngajare.Location = new System.Drawing.Point(103, 176);
            this.dtDataAngajare.Name = "dtDataAngajare";
            this.dtDataAngajare.Size = new System.Drawing.Size(136, 20);
            this.dtDataAngajare.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data angajare";
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
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(103, 134);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(136, 20);
            this.tbPrenume.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prenume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(103, 92);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(136, 20);
            this.tbNume.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nume";
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(103, 51);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(136, 20);
            this.tbCNP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNP";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // infoUserControl1
            // 
            this.infoUserControl1.Location = new System.Drawing.Point(12, 321);
            this.infoUserControl1.Name = "infoUserControl1";
            this.infoUserControl1.Size = new System.Drawing.Size(46, 43);
            this.infoUserControl1.TabIndex = 23;
            // 
            // FormOspatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.infoUserControl1);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.tbOspatari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "FormOspatar";
            this.Text = "Gestiune Ospatari";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInchide;
        private System.Windows.Forms.TextBox tbOspatari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDataAngajare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private InfoUserControl.InfoUserControl infoUserControl1;
    }
}
namespace MTPP_KLK2B
{
    partial class frmGlavna
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
            this.gbProvereZnanja = new System.Windows.Forms.GroupBox();
            this.gpPitanja = new System.Windows.Forms.GroupBox();
            this.gbOdgovori = new System.Windows.Forms.GroupBox();
            this.dgvProvereZnanja = new System.Windows.Forms.DataGridView();
            this.dgvPitanja = new System.Windows.Forms.DataGridView();
            this.dgvOdgovori = new System.Windows.Forms.DataGridView();
            this.txtNazivProvere = new System.Windows.Forms.TextBox();
            this.txtTrajanjeProvere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajProveruZnanja = new System.Windows.Forms.Button();
            this.txtIdProvereZnanja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPonistiDodavanjeProvereZnanja = new System.Windows.Forms.Button();
            this.btnObrisiProveruZnanja = new System.Windows.Forms.Button();
            this.btnObrisiPitanje = new System.Windows.Forms.Button();
            this.btnObrisiOdgovor = new System.Windows.Forms.Button();
            this.btnPonistiDodavanjePitanja = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPitanja = new System.Windows.Forms.TextBox();
            this.btnDodajPitanje = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTekstPitanja = new System.Windows.Forms.TextBox();
            this.cmbIdProvereZnanja = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIdPitanja = new System.Windows.Forms.ComboBox();
            this.btnPonistiDodavanjeOdgovora = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdOdgovora = new System.Windows.Forms.TextBox();
            this.btnDodajOdgovor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTekstOdgovora = new System.Windows.Forms.TextBox();
            this.gbProvereZnanja.SuspendLayout();
            this.gpPitanja.SuspendLayout();
            this.gbOdgovori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvereZnanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdgovori)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProvereZnanja
            // 
            this.gbProvereZnanja.Controls.Add(this.btnObrisiProveruZnanja);
            this.gbProvereZnanja.Controls.Add(this.btnPonistiDodavanjeProvereZnanja);
            this.gbProvereZnanja.Controls.Add(this.label4);
            this.gbProvereZnanja.Controls.Add(this.txtIdProvereZnanja);
            this.gbProvereZnanja.Controls.Add(this.btnDodajProveruZnanja);
            this.gbProvereZnanja.Controls.Add(this.label3);
            this.gbProvereZnanja.Controls.Add(this.textBox1);
            this.gbProvereZnanja.Controls.Add(this.label2);
            this.gbProvereZnanja.Controls.Add(this.label1);
            this.gbProvereZnanja.Controls.Add(this.txtTrajanjeProvere);
            this.gbProvereZnanja.Controls.Add(this.txtNazivProvere);
            this.gbProvereZnanja.Controls.Add(this.dgvProvereZnanja);
            this.gbProvereZnanja.Location = new System.Drawing.Point(13, 13);
            this.gbProvereZnanja.Name = "gbProvereZnanja";
            this.gbProvereZnanja.Size = new System.Drawing.Size(348, 425);
            this.gbProvereZnanja.TabIndex = 0;
            this.gbProvereZnanja.TabStop = false;
            this.gbProvereZnanja.Text = "ProvereZnanja";
            // 
            // gpPitanja
            // 
            this.gpPitanja.Controls.Add(this.label6);
            this.gpPitanja.Controls.Add(this.cmbIdProvereZnanja);
            this.gpPitanja.Controls.Add(this.btnPonistiDodavanjePitanja);
            this.gpPitanja.Controls.Add(this.label5);
            this.gpPitanja.Controls.Add(this.txtIdPitanja);
            this.gpPitanja.Controls.Add(this.btnDodajPitanje);
            this.gpPitanja.Controls.Add(this.label8);
            this.gpPitanja.Controls.Add(this.txtTekstPitanja);
            this.gpPitanja.Controls.Add(this.btnObrisiPitanje);
            this.gpPitanja.Controls.Add(this.dgvPitanja);
            this.gpPitanja.Location = new System.Drawing.Point(367, 13);
            this.gpPitanja.Name = "gpPitanja";
            this.gpPitanja.Size = new System.Drawing.Size(348, 425);
            this.gpPitanja.TabIndex = 1;
            this.gpPitanja.TabStop = false;
            this.gpPitanja.Text = "Pitanja";
            // 
            // gbOdgovori
            // 
            this.gbOdgovori.Controls.Add(this.label7);
            this.gbOdgovori.Controls.Add(this.btnObrisiOdgovor);
            this.gbOdgovori.Controls.Add(this.cmbIdPitanja);
            this.gbOdgovori.Controls.Add(this.dgvOdgovori);
            this.gbOdgovori.Controls.Add(this.btnPonistiDodavanjeOdgovora);
            this.gbOdgovori.Controls.Add(this.label9);
            this.gbOdgovori.Controls.Add(this.txtTekstOdgovora);
            this.gbOdgovori.Controls.Add(this.txtIdOdgovora);
            this.gbOdgovori.Controls.Add(this.label10);
            this.gbOdgovori.Controls.Add(this.btnDodajOdgovor);
            this.gbOdgovori.Location = new System.Drawing.Point(721, 13);
            this.gbOdgovori.Name = "gbOdgovori";
            this.gbOdgovori.Size = new System.Drawing.Size(348, 425);
            this.gbOdgovori.TabIndex = 2;
            this.gbOdgovori.TabStop = false;
            this.gbOdgovori.Text = "Odgovori";
            // 
            // dgvProvereZnanja
            // 
            this.dgvProvereZnanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvereZnanja.Location = new System.Drawing.Point(6, 228);
            this.dgvProvereZnanja.Name = "dgvProvereZnanja";
            this.dgvProvereZnanja.Size = new System.Drawing.Size(336, 191);
            this.dgvProvereZnanja.TabIndex = 0;
            // 
            // dgvPitanja
            // 
            this.dgvPitanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitanja.Location = new System.Drawing.Point(6, 228);
            this.dgvPitanja.Name = "dgvPitanja";
            this.dgvPitanja.Size = new System.Drawing.Size(336, 191);
            this.dgvPitanja.TabIndex = 1;
            // 
            // dgvOdgovori
            // 
            this.dgvOdgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdgovori.Location = new System.Drawing.Point(6, 228);
            this.dgvOdgovori.Name = "dgvOdgovori";
            this.dgvOdgovori.Size = new System.Drawing.Size(336, 191);
            this.dgvOdgovori.TabIndex = 2;
            // 
            // txtNazivProvere
            // 
            this.txtNazivProvere.Location = new System.Drawing.Point(147, 70);
            this.txtNazivProvere.Name = "txtNazivProvere";
            this.txtNazivProvere.Size = new System.Drawing.Size(100, 20);
            this.txtNazivProvere.TabIndex = 1;
            // 
            // txtTrajanjeProvere
            // 
            this.txtTrajanjeProvere.Location = new System.Drawing.Point(147, 122);
            this.txtTrajanjeProvere.Name = "txtTrajanjeProvere";
            this.txtTrajanjeProvere.Size = new System.Drawing.Size(100, 20);
            this.txtTrajanjeProvere.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trajanje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Godina*";
            // 
            // btnDodajProveruZnanja
            // 
            this.btnDodajProveruZnanja.Location = new System.Drawing.Point(99, 152);
            this.btnDodajProveruZnanja.Name = "btnDodajProveruZnanja";
            this.btnDodajProveruZnanja.Size = new System.Drawing.Size(74, 23);
            this.btnDodajProveruZnanja.TabIndex = 7;
            this.btnDodajProveruZnanja.Text = "Dodaj";
            this.btnDodajProveruZnanja.UseVisualStyleBackColor = true;
            // 
            // txtIdProvereZnanja
            // 
            this.txtIdProvereZnanja.Location = new System.Drawing.Point(147, 44);
            this.txtIdProvereZnanja.Name = "txtIdProvereZnanja";
            this.txtIdProvereZnanja.ReadOnly = true;
            this.txtIdProvereZnanja.Size = new System.Drawing.Size(100, 20);
            this.txtIdProvereZnanja.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            // 
            // btnPonistiDodavanjeProvereZnanja
            // 
            this.btnPonistiDodavanjeProvereZnanja.Location = new System.Drawing.Point(173, 152);
            this.btnPonistiDodavanjeProvereZnanja.Name = "btnPonistiDodavanjeProvereZnanja";
            this.btnPonistiDodavanjeProvereZnanja.Size = new System.Drawing.Size(74, 23);
            this.btnPonistiDodavanjeProvereZnanja.TabIndex = 10;
            this.btnPonistiDodavanjeProvereZnanja.Text = "Poništi";
            this.btnPonistiDodavanjeProvereZnanja.UseVisualStyleBackColor = true;
            // 
            // btnObrisiProveruZnanja
            // 
            this.btnObrisiProveruZnanja.Location = new System.Drawing.Point(268, 199);
            this.btnObrisiProveruZnanja.Name = "btnObrisiProveruZnanja";
            this.btnObrisiProveruZnanja.Size = new System.Drawing.Size(74, 23);
            this.btnObrisiProveruZnanja.TabIndex = 11;
            this.btnObrisiProveruZnanja.Text = "Obriši";
            this.btnObrisiProveruZnanja.UseVisualStyleBackColor = true;
            // 
            // btnObrisiPitanje
            // 
            this.btnObrisiPitanje.Location = new System.Drawing.Point(268, 199);
            this.btnObrisiPitanje.Name = "btnObrisiPitanje";
            this.btnObrisiPitanje.Size = new System.Drawing.Size(74, 23);
            this.btnObrisiPitanje.TabIndex = 12;
            this.btnObrisiPitanje.Text = "Obriši";
            this.btnObrisiPitanje.UseVisualStyleBackColor = true;
            // 
            // btnObrisiOdgovor
            // 
            this.btnObrisiOdgovor.Location = new System.Drawing.Point(268, 199);
            this.btnObrisiOdgovor.Name = "btnObrisiOdgovor";
            this.btnObrisiOdgovor.Size = new System.Drawing.Size(74, 23);
            this.btnObrisiOdgovor.TabIndex = 13;
            this.btnObrisiOdgovor.Text = "Obriši";
            this.btnObrisiOdgovor.UseVisualStyleBackColor = true;
            // 
            // btnPonistiDodavanjePitanja
            // 
            this.btnPonistiDodavanjePitanja.Location = new System.Drawing.Point(172, 122);
            this.btnPonistiDodavanjePitanja.Name = "btnPonistiDodavanjePitanja";
            this.btnPonistiDodavanjePitanja.Size = new System.Drawing.Size(74, 23);
            this.btnPonistiDodavanjePitanja.TabIndex = 22;
            this.btnPonistiDodavanjePitanja.Text = "Poništi";
            this.btnPonistiDodavanjePitanja.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID";
            // 
            // txtIdPitanja
            // 
            this.txtIdPitanja.Location = new System.Drawing.Point(146, 44);
            this.txtIdPitanja.Name = "txtIdPitanja";
            this.txtIdPitanja.ReadOnly = true;
            this.txtIdPitanja.Size = new System.Drawing.Size(100, 20);
            this.txtIdPitanja.TabIndex = 20;
            // 
            // btnDodajPitanje
            // 
            this.btnDodajPitanje.Location = new System.Drawing.Point(98, 122);
            this.btnDodajPitanje.Name = "btnDodajPitanje";
            this.btnDodajPitanje.Size = new System.Drawing.Size(74, 23);
            this.btnDodajPitanje.TabIndex = 19;
            this.btnDodajPitanje.Text = "Dodaj";
            this.btnDodajPitanje.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tekst*";
            // 
            // txtTekstPitanja
            // 
            this.txtTekstPitanja.Location = new System.Drawing.Point(146, 70);
            this.txtTekstPitanja.Name = "txtTekstPitanja";
            this.txtTekstPitanja.Size = new System.Drawing.Size(100, 20);
            this.txtTekstPitanja.TabIndex = 13;
            // 
            // cmbIdProvereZnanja
            // 
            this.cmbIdProvereZnanja.FormattingEnabled = true;
            this.cmbIdProvereZnanja.Location = new System.Drawing.Point(146, 95);
            this.cmbIdProvereZnanja.Name = "cmbIdProvereZnanja";
            this.cmbIdProvereZnanja.Size = new System.Drawing.Size(100, 21);
            this.cmbIdProvereZnanja.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "ID provere znanja*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID pitanja*";
            // 
            // cmbIdPitanja
            // 
            this.cmbIdPitanja.FormattingEnabled = true;
            this.cmbIdPitanja.Location = new System.Drawing.Point(160, 95);
            this.cmbIdPitanja.Name = "cmbIdPitanja";
            this.cmbIdPitanja.Size = new System.Drawing.Size(100, 21);
            this.cmbIdPitanja.TabIndex = 31;
            // 
            // btnPonistiDodavanjeOdgovora
            // 
            this.btnPonistiDodavanjeOdgovora.Location = new System.Drawing.Point(186, 122);
            this.btnPonistiDodavanjeOdgovora.Name = "btnPonistiDodavanjeOdgovora";
            this.btnPonistiDodavanjeOdgovora.Size = new System.Drawing.Size(74, 23);
            this.btnPonistiDodavanjeOdgovora.TabIndex = 30;
            this.btnPonistiDodavanjeOdgovora.Text = "Poništi";
            this.btnPonistiDodavanjeOdgovora.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "ID";
            // 
            // txtIdOdgovora
            // 
            this.txtIdOdgovora.Location = new System.Drawing.Point(160, 44);
            this.txtIdOdgovora.Name = "txtIdOdgovora";
            this.txtIdOdgovora.ReadOnly = true;
            this.txtIdOdgovora.Size = new System.Drawing.Size(100, 20);
            this.txtIdOdgovora.TabIndex = 28;
            // 
            // btnDodajOdgovor
            // 
            this.btnDodajOdgovor.Location = new System.Drawing.Point(112, 122);
            this.btnDodajOdgovor.Name = "btnDodajOdgovor";
            this.btnDodajOdgovor.Size = new System.Drawing.Size(74, 23);
            this.btnDodajOdgovor.TabIndex = 27;
            this.btnDodajOdgovor.Text = "Dodaj";
            this.btnDodajOdgovor.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tekst*";
            // 
            // txtTekstOdgovora
            // 
            this.txtTekstOdgovora.Location = new System.Drawing.Point(160, 70);
            this.txtTekstOdgovora.Name = "txtTekstOdgovora";
            this.txtTekstOdgovora.Size = new System.Drawing.Size(100, 20);
            this.txtTekstOdgovora.TabIndex = 25;
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 449);
            this.Controls.Add(this.gbOdgovori);
            this.Controls.Add(this.gpPitanja);
            this.Controls.Add(this.gbProvereZnanja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmGlavna";
            this.Text = "Glavna";
            this.gbProvereZnanja.ResumeLayout(false);
            this.gbProvereZnanja.PerformLayout();
            this.gpPitanja.ResumeLayout(false);
            this.gpPitanja.PerformLayout();
            this.gbOdgovori.ResumeLayout(false);
            this.gbOdgovori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvereZnanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdgovori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProvereZnanja;
        private System.Windows.Forms.DataGridView dgvProvereZnanja;
        private System.Windows.Forms.GroupBox gpPitanja;
        private System.Windows.Forms.DataGridView dgvPitanja;
        private System.Windows.Forms.GroupBox gbOdgovori;
        private System.Windows.Forms.DataGridView dgvOdgovori;
        private System.Windows.Forms.Button btnDodajProveruZnanja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrajanjeProvere;
        private System.Windows.Forms.TextBox txtNazivProvere;
        private System.Windows.Forms.Button btnPonistiDodavanjeProvereZnanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProvereZnanja;
        private System.Windows.Forms.Button btnObrisiProveruZnanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIdProvereZnanja;
        private System.Windows.Forms.Button btnPonistiDodavanjePitanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdPitanja;
        private System.Windows.Forms.Button btnDodajPitanje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTekstPitanja;
        private System.Windows.Forms.Button btnObrisiPitanje;
        private System.Windows.Forms.Button btnObrisiOdgovor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIdPitanja;
        private System.Windows.Forms.Button btnPonistiDodavanjeOdgovora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTekstOdgovora;
        private System.Windows.Forms.TextBox txtIdOdgovora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDodajOdgovor;
    }
}


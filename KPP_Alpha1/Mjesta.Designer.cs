﻿namespace KPP_Alpha1
{
    partial class form_Mjesta
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
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.btn_Uredi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.dgv_mjesta = new System.Windows.Forms.DataGridView();
            this.txt_Mjesto = new System.Windows.Forms.TextBox();
            this.txt_Ptt = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_mjesto = new System.Windows.Forms.Label();
            this.lbl_ptt = new System.Windows.Forms.Label();
            this.lbl_id_korisnik = new System.Windows.Forms.Label();
            this.txt_Zupanija = new System.Windows.Forms.TextBox();
            this.lbl_zupanija = new System.Windows.Forms.Label();
            this.txt_secKey = new System.Windows.Forms.TextBox();
            this.lbl_secKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mjesta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(12, 180);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(112, 23);
            this.lbl_pretrazivanje.TabIndex = 37;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pretrazivanje.Location = new System.Drawing.Point(148, 176);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(622, 30);
            this.txt_pretrazivanje.TabIndex = 36;
            this.txt_pretrazivanje.TabStop = false;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretrazivanje_TextChanged);
            // 
            // btn_Uredi
            // 
            this.btn_Uredi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Uredi.Location = new System.Drawing.Point(695, 70);
            this.btn_Uredi.Name = "btn_Uredi";
            this.btn_Uredi.Size = new System.Drawing.Size(75, 35);
            this.btn_Uredi.TabIndex = 34;
            this.btn_Uredi.TabStop = false;
            this.btn_Uredi.Text = "Uredi";
            this.btn_Uredi.UseVisualStyleBackColor = true;
            this.btn_Uredi.Click += new System.EventHandler(this.btn_Uredi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dodaj.Location = new System.Drawing.Point(680, 18);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(90, 35);
            this.btn_dodaj.TabIndex = 4;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // dgv_mjesta
            // 
            this.dgv_mjesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_mjesta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mjesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mjesta.Location = new System.Drawing.Point(12, 232);
            this.dgv_mjesta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_mjesta.Name = "dgv_mjesta";
            this.dgv_mjesta.RowTemplate.Height = 24;
            this.dgv_mjesta.Size = new System.Drawing.Size(758, 304);
            this.dgv_mjesta.TabIndex = 33;
            this.dgv_mjesta.TabStop = false;
            this.dgv_mjesta.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_mjesta_RowHeaderMouseClick);
            // 
            // txt_Mjesto
            // 
            this.txt_Mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Mjesto.Location = new System.Drawing.Point(148, 98);
            this.txt_Mjesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Mjesto.Name = "txt_Mjesto";
            this.txt_Mjesto.Size = new System.Drawing.Size(210, 30);
            this.txt_Mjesto.TabIndex = 2;
            // 
            // txt_Ptt
            // 
            this.txt_Ptt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Ptt.Location = new System.Drawing.Point(148, 59);
            this.txt_Ptt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ptt.Name = "txt_Ptt";
            this.txt_Ptt.Size = new System.Drawing.Size(210, 30);
            this.txt_Ptt.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.Location = new System.Drawing.Point(148, 20);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 30);
            this.txt_id.TabIndex = 28;
            this.txt_id.TabStop = false;
            // 
            // lbl_mjesto
            // 
            this.lbl_mjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mjesto.AutoSize = true;
            this.lbl_mjesto.Location = new System.Drawing.Point(12, 102);
            this.lbl_mjesto.Name = "lbl_mjesto";
            this.lbl_mjesto.Size = new System.Drawing.Size(65, 23);
            this.lbl_mjesto.TabIndex = 31;
            this.lbl_mjesto.Text = "Mjesto:";
            // 
            // lbl_ptt
            // 
            this.lbl_ptt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ptt.AutoSize = true;
            this.lbl_ptt.Location = new System.Drawing.Point(12, 63);
            this.lbl_ptt.Name = "lbl_ptt";
            this.lbl_ptt.Size = new System.Drawing.Size(42, 23);
            this.lbl_ptt.TabIndex = 29;
            this.lbl_ptt.Text = "PTT:";
            // 
            // lbl_id_korisnik
            // 
            this.lbl_id_korisnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id_korisnik.AutoSize = true;
            this.lbl_id_korisnik.Location = new System.Drawing.Point(12, 24);
            this.lbl_id_korisnik.Name = "lbl_id_korisnik";
            this.lbl_id_korisnik.Size = new System.Drawing.Size(31, 23);
            this.lbl_id_korisnik.TabIndex = 26;
            this.lbl_id_korisnik.Text = "ID:";
            // 
            // txt_Zupanija
            // 
            this.txt_Zupanija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Zupanija.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Zupanija.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Zupanija.Location = new System.Drawing.Point(148, 137);
            this.txt_Zupanija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Zupanija.Name = "txt_Zupanija";
            this.txt_Zupanija.Size = new System.Drawing.Size(210, 30);
            this.txt_Zupanija.TabIndex = 3;
            // 
            // lbl_zupanija
            // 
            this.lbl_zupanija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_zupanija.AutoSize = true;
            this.lbl_zupanija.Location = new System.Drawing.Point(12, 141);
            this.lbl_zupanija.Name = "lbl_zupanija";
            this.lbl_zupanija.Size = new System.Drawing.Size(76, 23);
            this.lbl_zupanija.TabIndex = 40;
            this.lbl_zupanija.Text = "Županija";
            // 
            // txt_secKey
            // 
            this.txt_secKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_secKey.Location = new System.Drawing.Point(463, 137);
            this.txt_secKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_secKey.Name = "txt_secKey";
            this.txt_secKey.Size = new System.Drawing.Size(105, 30);
            this.txt_secKey.TabIndex = 42;
            this.txt_secKey.TabStop = false;
            // 
            // lbl_secKey
            // 
            this.lbl_secKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_secKey.AutoSize = true;
            this.lbl_secKey.Location = new System.Drawing.Point(368, 141);
            this.lbl_secKey.Name = "lbl_secKey";
            this.lbl_secKey.Size = new System.Drawing.Size(65, 23);
            this.lbl_secKey.TabIndex = 41;
            this.lbl_secKey.Text = "secKey:";
            // 
            // form_Mjesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.txt_secKey);
            this.Controls.Add(this.lbl_secKey);
            this.Controls.Add(this.txt_Zupanija);
            this.Controls.Add(this.lbl_zupanija);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.btn_Uredi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.dgv_mjesta);
            this.Controls.Add(this.txt_Mjesto);
            this.Controls.Add(this.txt_Ptt);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_mjesto);
            this.Controls.Add(this.lbl_ptt);
            this.Controls.Add(this.lbl_id_korisnik);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Mjesta";
            this.Text = "Mjesta";
            this.Load += new System.EventHandler(this.Form_Mjesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mjesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Button btn_Uredi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.DataGridView dgv_mjesta;
        private System.Windows.Forms.TextBox txt_Mjesto;
        private System.Windows.Forms.TextBox txt_Ptt;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_mjesto;
        private System.Windows.Forms.Label lbl_ptt;
        private System.Windows.Forms.Label lbl_id_korisnik;
        private System.Windows.Forms.TextBox txt_Zupanija;
        private System.Windows.Forms.Label lbl_zupanija;
        private System.Windows.Forms.TextBox txt_secKey;
        private System.Windows.Forms.Label lbl_secKey;
    }
}
namespace RentaCarNtp
{
    partial class formMusteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMusteriListele));
            this.maskedTextBoxTelNo = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxEposta = new System.Windows.Forms.TextBox();
            this.textBoxTcNo = new System.Windows.Forms.TextBox();
            this.labelTcNo = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTelNo = new System.Windows.Forms.Label();
            this.labelEPosta = new System.Windows.Forms.Label();
            this.buttonMusteriCikis = new System.Windows.Forms.Button();
            this.buttonMusteriGuncelle = new System.Windows.Forms.Button();
            this.buttonMusteriSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxTelNo
            // 
            this.maskedTextBoxTelNo.Location = new System.Drawing.Point(150, 91);
            this.maskedTextBoxTelNo.Mask = "(999) 000-0000";
            this.maskedTextBoxTelNo.Name = "maskedTextBoxTelNo";
            this.maskedTextBoxTelNo.Size = new System.Drawing.Size(199, 22);
            this.maskedTextBoxTelNo.TabIndex = 17;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(150, 171);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(199, 87);
            this.textBoxAdres.TabIndex = 16;
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(150, 56);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(199, 22);
            this.textBoxAdSoyad.TabIndex = 15;
            // 
            // textBoxEposta
            // 
            this.textBoxEposta.Location = new System.Drawing.Point(150, 131);
            this.textBoxEposta.Name = "textBoxEposta";
            this.textBoxEposta.Size = new System.Drawing.Size(199, 22);
            this.textBoxEposta.TabIndex = 14;
            // 
            // textBoxTcNo
            // 
            this.textBoxTcNo.Location = new System.Drawing.Point(150, 19);
            this.textBoxTcNo.Name = "textBoxTcNo";
            this.textBoxTcNo.Size = new System.Drawing.Size(199, 22);
            this.textBoxTcNo.TabIndex = 13;
            // 
            // labelTcNo
            // 
            this.labelTcNo.AutoSize = true;
            this.labelTcNo.Location = new System.Drawing.Point(23, 25);
            this.labelTcNo.Name = "labelTcNo";
            this.labelTcNo.Size = new System.Drawing.Size(86, 16);
            this.labelTcNo.TabIndex = 8;
            this.labelTcNo.Text = "TC Numarası";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(25, 56);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(67, 16);
            this.labelAdSoyad.TabIndex = 9;
            this.labelAdSoyad.Text = "Ad Soyad";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(25, 202);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(43, 16);
            this.labelAdres.TabIndex = 10;
            this.labelAdres.Text = "Adres";
            // 
            // labelTelNo
            // 
            this.labelTelNo.AutoSize = true;
            this.labelTelNo.Location = new System.Drawing.Point(23, 94);
            this.labelTelNo.Name = "labelTelNo";
            this.labelTelNo.Size = new System.Drawing.Size(114, 16);
            this.labelTelNo.TabIndex = 11;
            this.labelTelNo.Text = "Telefon Numarası";
            // 
            // labelEPosta
            // 
            this.labelEPosta.AutoSize = true;
            this.labelEPosta.Location = new System.Drawing.Point(25, 131);
            this.labelEPosta.Name = "labelEPosta";
            this.labelEPosta.Size = new System.Drawing.Size(55, 16);
            this.labelEPosta.TabIndex = 12;
            this.labelEPosta.Text = "E-Posta";
            // 
            // buttonMusteriCikis
            // 
            this.buttonMusteriCikis.Image = ((System.Drawing.Image)(resources.GetObject("buttonMusteriCikis.Image")));
            this.buttonMusteriCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMusteriCikis.Location = new System.Drawing.Point(37, 289);
            this.buttonMusteriCikis.Name = "buttonMusteriCikis";
            this.buttonMusteriCikis.Size = new System.Drawing.Size(100, 53);
            this.buttonMusteriCikis.TabIndex = 18;
            this.buttonMusteriCikis.Text = "Çıkış";
            this.buttonMusteriCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMusteriCikis.UseVisualStyleBackColor = true;
            this.buttonMusteriCikis.Click += new System.EventHandler(this.buttonMusteriKaydet_Click);
            // 
            // buttonMusteriGuncelle
            // 
            this.buttonMusteriGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("buttonMusteriGuncelle.Image")));
            this.buttonMusteriGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMusteriGuncelle.Location = new System.Drawing.Point(249, 289);
            this.buttonMusteriGuncelle.Name = "buttonMusteriGuncelle";
            this.buttonMusteriGuncelle.Size = new System.Drawing.Size(100, 53);
            this.buttonMusteriGuncelle.TabIndex = 18;
            this.buttonMusteriGuncelle.Text = "Güncelle";
            this.buttonMusteriGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMusteriGuncelle.UseVisualStyleBackColor = true;
            this.buttonMusteriGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonMusteriSil
            // 
            this.buttonMusteriSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonMusteriSil.Image")));
            this.buttonMusteriSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMusteriSil.Location = new System.Drawing.Point(150, 289);
            this.buttonMusteriSil.Name = "buttonMusteriSil";
            this.buttonMusteriSil.Size = new System.Drawing.Size(93, 53);
            this.buttonMusteriSil.TabIndex = 19;
            this.buttonMusteriSil.Text = "Müşteri Sil";
            this.buttonMusteriSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMusteriSil.UseVisualStyleBackColor = true;
            this.buttonMusteriSil.Click += new System.EventHandler(this.buttonMusteriSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(385, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(871, 419);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // formMusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMusteriSil);
            this.Controls.Add(this.buttonMusteriGuncelle);
            this.Controls.Add(this.buttonMusteriCikis);
            this.Controls.Add(this.maskedTextBoxTelNo);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.textBoxEposta);
            this.Controls.Add(this.textBoxTcNo);
            this.Controls.Add(this.labelTcNo);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelTelNo);
            this.Controls.Add(this.labelEPosta);
            this.Name = "formMusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listele";
            this.Load += new System.EventHandler(this.formMusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelNo;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxEposta;
        private System.Windows.Forms.TextBox textBoxTcNo;
        private System.Windows.Forms.Label labelTcNo;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTelNo;
        private System.Windows.Forms.Label labelEPosta;
        private System.Windows.Forms.Button buttonMusteriCikis;
        private System.Windows.Forms.Button buttonMusteriGuncelle;
        private System.Windows.Forms.Button buttonMusteriSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
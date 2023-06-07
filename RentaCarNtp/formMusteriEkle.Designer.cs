namespace RentaCarNtp
{
    partial class formMusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMusteriEkle));
            this.labelEPosta = new System.Windows.Forms.Label();
            this.labelTelNo = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.labelTcNo = new System.Windows.Forms.Label();
            this.textBoxTcNo = new System.Windows.Forms.TextBox();
            this.textBoxEposta = new System.Windows.Forms.TextBox();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelNo = new System.Windows.Forms.MaskedTextBox();
            this.buttonMusteriKaydet = new System.Windows.Forms.Button();
            this.buttonMusteriCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEPosta
            // 
            this.labelEPosta.AutoSize = true;
            this.labelEPosta.Location = new System.Drawing.Point(34, 135);
            this.labelEPosta.Name = "labelEPosta";
            this.labelEPosta.Size = new System.Drawing.Size(55, 16);
            this.labelEPosta.TabIndex = 0;
            this.labelEPosta.Text = "E-Posta";
            // 
            // labelTelNo
            // 
            this.labelTelNo.AutoSize = true;
            this.labelTelNo.Location = new System.Drawing.Point(32, 98);
            this.labelTelNo.Name = "labelTelNo";
            this.labelTelNo.Size = new System.Drawing.Size(114, 16);
            this.labelTelNo.TabIndex = 0;
            this.labelTelNo.Text = "Telefon Numarası";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(34, 206);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(43, 16);
            this.labelAdres.TabIndex = 0;
            this.labelAdres.Text = "Adres";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(34, 60);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(67, 16);
            this.labelAdSoyad.TabIndex = 0;
            this.labelAdSoyad.Text = "Ad Soyad";
            // 
            // labelTcNo
            // 
            this.labelTcNo.AutoSize = true;
            this.labelTcNo.Location = new System.Drawing.Point(32, 29);
            this.labelTcNo.Name = "labelTcNo";
            this.labelTcNo.Size = new System.Drawing.Size(86, 16);
            this.labelTcNo.TabIndex = 0;
            this.labelTcNo.Text = "TC Numarası";
            // 
            // textBoxTcNo
            // 
            this.textBoxTcNo.Location = new System.Drawing.Point(152, 26);
            this.textBoxTcNo.Name = "textBoxTcNo";
            this.textBoxTcNo.Size = new System.Drawing.Size(199, 22);
            this.textBoxTcNo.TabIndex = 1;
            // 
            // textBoxEposta
            // 
            this.textBoxEposta.Location = new System.Drawing.Point(152, 135);
            this.textBoxEposta.Name = "textBoxEposta";
            this.textBoxEposta.Size = new System.Drawing.Size(199, 22);
            this.textBoxEposta.TabIndex = 3;
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(152, 64);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(199, 22);
            this.textBoxAdSoyad.TabIndex = 5;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(152, 176);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(199, 87);
            this.textBoxAdres.TabIndex = 6;
            // 
            // maskedTextBoxTelNo
            // 
            this.maskedTextBoxTelNo.Location = new System.Drawing.Point(152, 98);
            this.maskedTextBoxTelNo.Mask = "(999) 000-0000";
            this.maskedTextBoxTelNo.Name = "maskedTextBoxTelNo";
            this.maskedTextBoxTelNo.Size = new System.Drawing.Size(199, 22);
            this.maskedTextBoxTelNo.TabIndex = 7;
            // 
            // buttonMusteriKaydet
            // 
            this.buttonMusteriKaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonMusteriKaydet.Image")));
            this.buttonMusteriKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMusteriKaydet.Location = new System.Drawing.Point(152, 278);
            this.buttonMusteriKaydet.Name = "buttonMusteriKaydet";
            this.buttonMusteriKaydet.Size = new System.Drawing.Size(100, 53);
            this.buttonMusteriKaydet.TabIndex = 9;
            this.buttonMusteriKaydet.Text = "Kaydet";
            this.buttonMusteriKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMusteriKaydet.UseVisualStyleBackColor = true;
            this.buttonMusteriKaydet.Click += new System.EventHandler(this.buttonMusteriKaydet_Click);
            // 
            // buttonMusteriCikis
            // 
            this.buttonMusteriCikis.Image = ((System.Drawing.Image)(resources.GetObject("buttonMusteriCikis.Image")));
            this.buttonMusteriCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMusteriCikis.Location = new System.Drawing.Point(258, 278);
            this.buttonMusteriCikis.Name = "buttonMusteriCikis";
            this.buttonMusteriCikis.Size = new System.Drawing.Size(93, 53);
            this.buttonMusteriCikis.TabIndex = 10;
            this.buttonMusteriCikis.Text = "Çıkış";
            this.buttonMusteriCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMusteriCikis.UseVisualStyleBackColor = true;
            this.buttonMusteriCikis.Click += new System.EventHandler(this.buttonMusteriCikis_Click);
            // 
            // formMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 474);
            this.Controls.Add(this.buttonMusteriCikis);
            this.Controls.Add(this.buttonMusteriKaydet);
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
            this.Name = "formMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEPosta;
        private System.Windows.Forms.Label labelTelNo;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label labelTcNo;
        private System.Windows.Forms.TextBox textBoxTcNo;
        private System.Windows.Forms.TextBox textBoxEposta;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelNo;
        private System.Windows.Forms.Button buttonMusteriKaydet;
        private System.Windows.Forms.Button buttonMusteriCikis;
    }
}
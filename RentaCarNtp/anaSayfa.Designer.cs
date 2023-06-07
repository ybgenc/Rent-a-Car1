namespace RentaCarNtp
{
    partial class anaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaSayfa));
            this.buttonMusteriEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonMusteriListesi = new System.Windows.Forms.Button();
            this.buttonArabaListesi = new System.Windows.Forms.Button();
            this.buttonArabaEkle = new System.Windows.Forms.Button();
            this.buttonSozlesme = new System.Windows.Forms.Button();
            this.buttonSatıslar = new System.Windows.Forms.Button();
            this.buttonGuvenliCikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMusteriEkle
            // 
            this.buttonMusteriEkle.BackColor = System.Drawing.Color.Transparent;
            this.buttonMusteriEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMusteriEkle.ImageKey = "add-user.png";
            this.buttonMusteriEkle.ImageList = this.ımageList1;
            this.buttonMusteriEkle.Location = new System.Drawing.Point(12, 12);
            this.buttonMusteriEkle.Name = "buttonMusteriEkle";
            this.buttonMusteriEkle.Size = new System.Drawing.Size(101, 81);
            this.buttonMusteriEkle.TabIndex = 1;
            this.buttonMusteriEkle.Text = "Müşteri Ekle";
            this.buttonMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMusteriEkle.UseVisualStyleBackColor = false;
            this.buttonMusteriEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add-user.png");
            this.ımageList1.Images.SetKeyName(1, "car (1).png");
            this.ımageList1.Images.SetKeyName(2, "car.png");
            this.ımageList1.Images.SetKeyName(3, "contract.png");
            this.ımageList1.Images.SetKeyName(4, "customer.png");
            this.ımageList1.Images.SetKeyName(5, "money-bag.png");
            this.ımageList1.Images.SetKeyName(6, "logout.png");
            this.ımageList1.Images.SetKeyName(7, "log-out (1).png");
            // 
            // buttonMusteriListesi
            // 
            this.buttonMusteriListesi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMusteriListesi.ImageKey = "customer.png";
            this.buttonMusteriListesi.ImageList = this.ımageList1;
            this.buttonMusteriListesi.Location = new System.Drawing.Point(12, 99);
            this.buttonMusteriListesi.Name = "buttonMusteriListesi";
            this.buttonMusteriListesi.Size = new System.Drawing.Size(101, 97);
            this.buttonMusteriListesi.TabIndex = 1;
            this.buttonMusteriListesi.Text = "Müşteri Listesi";
            this.buttonMusteriListesi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMusteriListesi.UseVisualStyleBackColor = true;
            this.buttonMusteriListesi.Click += new System.EventHandler(this.buttonMusteriListesi_Click);
            // 
            // buttonArabaListesi
            // 
            this.buttonArabaListesi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonArabaListesi.ImageKey = "car (1).png";
            this.buttonArabaListesi.ImageList = this.ımageList1;
            this.buttonArabaListesi.Location = new System.Drawing.Point(12, 295);
            this.buttonArabaListesi.Name = "buttonArabaListesi";
            this.buttonArabaListesi.Size = new System.Drawing.Size(101, 79);
            this.buttonArabaListesi.TabIndex = 1;
            this.buttonArabaListesi.Text = "Araç Listesi";
            this.buttonArabaListesi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonArabaListesi.UseVisualStyleBackColor = true;
            this.buttonArabaListesi.Click += new System.EventHandler(this.buttonArabaListesi_Click);
            // 
            // buttonArabaEkle
            // 
            this.buttonArabaEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonArabaEkle.ImageKey = "car.png";
            this.buttonArabaEkle.ImageList = this.ımageList1;
            this.buttonArabaEkle.Location = new System.Drawing.Point(12, 202);
            this.buttonArabaEkle.Name = "buttonArabaEkle";
            this.buttonArabaEkle.Size = new System.Drawing.Size(101, 87);
            this.buttonArabaEkle.TabIndex = 1;
            this.buttonArabaEkle.Text = "Araç Ekle";
            this.buttonArabaEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonArabaEkle.UseVisualStyleBackColor = true;
            this.buttonArabaEkle.Click += new System.EventHandler(this.buttonArabaEkle_Click);
            // 
            // buttonSozlesme
            // 
            this.buttonSozlesme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSozlesme.ImageKey = "contract.png";
            this.buttonSozlesme.ImageList = this.ımageList1;
            this.buttonSozlesme.Location = new System.Drawing.Point(12, 380);
            this.buttonSozlesme.Name = "buttonSozlesme";
            this.buttonSozlesme.Size = new System.Drawing.Size(101, 83);
            this.buttonSozlesme.TabIndex = 1;
            this.buttonSozlesme.Text = "Sözleşme";
            this.buttonSozlesme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSozlesme.UseVisualStyleBackColor = true;
            this.buttonSozlesme.Click += new System.EventHandler(this.buttonSozlesme_Click);
            // 
            // buttonSatıslar
            // 
            this.buttonSatıslar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSatıslar.ImageKey = "money-bag.png";
            this.buttonSatıslar.ImageList = this.ımageList1;
            this.buttonSatıslar.Location = new System.Drawing.Point(12, 469);
            this.buttonSatıslar.Name = "buttonSatıslar";
            this.buttonSatıslar.Size = new System.Drawing.Size(101, 84);
            this.buttonSatıslar.TabIndex = 1;
            this.buttonSatıslar.Text = "Satışlar";
            this.buttonSatıslar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSatıslar.UseVisualStyleBackColor = true;
            this.buttonSatıslar.Click += new System.EventHandler(this.buttonSatıslar_Click);
            // 
            // buttonGuvenliCikis
            // 
            this.buttonGuvenliCikis.BackColor = System.Drawing.Color.White;
            this.buttonGuvenliCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuvenliCikis.ImageKey = "log-out (1).png";
            this.buttonGuvenliCikis.ImageList = this.ımageList1;
            this.buttonGuvenliCikis.Location = new System.Drawing.Point(12, 559);
            this.buttonGuvenliCikis.Name = "buttonGuvenliCikis";
            this.buttonGuvenliCikis.Size = new System.Drawing.Size(101, 73);
            this.buttonGuvenliCikis.TabIndex = 1;
            this.buttonGuvenliCikis.Text = "Güvenli Çıkış";
            this.buttonGuvenliCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuvenliCikis.UseVisualStyleBackColor = false;
            this.buttonGuvenliCikis.Click += new System.EventHandler(this.buttonGuvenliCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGuvenliCikis);
            this.Controls.Add(this.buttonSatıslar);
            this.Controls.Add(this.buttonSozlesme);
            this.Controls.Add(this.buttonArabaEkle);
            this.Controls.Add(this.buttonArabaListesi);
            this.Controls.Add(this.buttonMusteriListesi);
            this.Controls.Add(this.buttonMusteriEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NTP Rent A Car";
            this.Load += new System.EventHandler(this.anaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMusteriEkle;
        private System.Windows.Forms.Button buttonMusteriListesi;
        private System.Windows.Forms.Button buttonArabaListesi;
        private System.Windows.Forms.Button buttonArabaEkle;
        private System.Windows.Forms.Button buttonSozlesme;
        private System.Windows.Forms.Button buttonSatıslar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button buttonGuvenliCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace RentaCarNtp
{
    partial class FormAracListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAracListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAracListeleUcret = new System.Windows.Forms.TextBox();
            this.textBoxAracListeleKilometre = new System.Windows.Forms.TextBox();
            this.textBoxAracListeleRenk = new System.Windows.Forms.TextBox();
            this.textBoxAracListelePlaka = new System.Windows.Forms.TextBox();
            this.textBoxAracListeleModel = new System.Windows.Forms.TextBox();
            this.comboBoxAracListeleDurum = new System.Windows.Forms.ComboBox();
            this.comboBoxAracListeleYakıt = new System.Windows.Forms.ComboBox();
            this.comboBoxAracListeleSeri = new System.Windows.Forms.ComboBox();
            this.comboBoxAracListeleMarka = new System.Windows.Forms.ComboBox();
            this.buttonAracListeleCikis = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAracSil = new System.Windows.Forms.Button();
            this.buttonMusteriGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 450);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxAracListeleUcret
            // 
            this.textBoxAracListeleUcret.Location = new System.Drawing.Point(114, 317);
            this.textBoxAracListeleUcret.Name = "textBoxAracListeleUcret";
            this.textBoxAracListeleUcret.Size = new System.Drawing.Size(161, 22);
            this.textBoxAracListeleUcret.TabIndex = 54;
            // 
            // textBoxAracListeleKilometre
            // 
            this.textBoxAracListeleKilometre.Location = new System.Drawing.Point(114, 233);
            this.textBoxAracListeleKilometre.Name = "textBoxAracListeleKilometre";
            this.textBoxAracListeleKilometre.Size = new System.Drawing.Size(161, 22);
            this.textBoxAracListeleKilometre.TabIndex = 53;
            // 
            // textBoxAracListeleRenk
            // 
            this.textBoxAracListeleRenk.Location = new System.Drawing.Point(114, 194);
            this.textBoxAracListeleRenk.Name = "textBoxAracListeleRenk";
            this.textBoxAracListeleRenk.Size = new System.Drawing.Size(161, 22);
            this.textBoxAracListeleRenk.TabIndex = 52;
            // 
            // textBoxAracListelePlaka
            // 
            this.textBoxAracListelePlaka.Location = new System.Drawing.Point(114, 151);
            this.textBoxAracListelePlaka.Name = "textBoxAracListelePlaka";
            this.textBoxAracListelePlaka.Size = new System.Drawing.Size(161, 22);
            this.textBoxAracListelePlaka.TabIndex = 51;
            // 
            // textBoxAracListeleModel
            // 
            this.textBoxAracListeleModel.Location = new System.Drawing.Point(114, 106);
            this.textBoxAracListeleModel.Name = "textBoxAracListeleModel";
            this.textBoxAracListeleModel.Size = new System.Drawing.Size(161, 22);
            this.textBoxAracListeleModel.TabIndex = 50;
            // 
            // comboBoxAracListeleDurum
            // 
            this.comboBoxAracListeleDurum.FormattingEnabled = true;
            this.comboBoxAracListeleDurum.Items.AddRange(new object[] {
            "Kiralandı",
            "Müsait"});
            this.comboBoxAracListeleDurum.Location = new System.Drawing.Point(114, 359);
            this.comboBoxAracListeleDurum.Name = "comboBoxAracListeleDurum";
            this.comboBoxAracListeleDurum.Size = new System.Drawing.Size(161, 24);
            this.comboBoxAracListeleDurum.TabIndex = 49;
            // 
            // comboBoxAracListeleYakıt
            // 
            this.comboBoxAracListeleYakıt.FormattingEnabled = true;
            this.comboBoxAracListeleYakıt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin ",
            "Hybrit",
            "Elektrik"});
            this.comboBoxAracListeleYakıt.Location = new System.Drawing.Point(114, 272);
            this.comboBoxAracListeleYakıt.Name = "comboBoxAracListeleYakıt";
            this.comboBoxAracListeleYakıt.Size = new System.Drawing.Size(161, 24);
            this.comboBoxAracListeleYakıt.TabIndex = 48;
            // 
            // comboBoxAracListeleSeri
            // 
            this.comboBoxAracListeleSeri.FormattingEnabled = true;
            this.comboBoxAracListeleSeri.Location = new System.Drawing.Point(114, 67);
            this.comboBoxAracListeleSeri.Name = "comboBoxAracListeleSeri";
            this.comboBoxAracListeleSeri.Size = new System.Drawing.Size(161, 24);
            this.comboBoxAracListeleSeri.TabIndex = 47;
            // 
            // comboBoxAracListeleMarka
            // 
            this.comboBoxAracListeleMarka.FormattingEnabled = true;
            this.comboBoxAracListeleMarka.Items.AddRange(new object[] {
            "BMW",
            "MERCEDES",
            "AUDI",
            "VOLKSWAGEN"});
            this.comboBoxAracListeleMarka.Location = new System.Drawing.Point(114, 19);
            this.comboBoxAracListeleMarka.Name = "comboBoxAracListeleMarka";
            this.comboBoxAracListeleMarka.Size = new System.Drawing.Size(161, 24);
            this.comboBoxAracListeleMarka.TabIndex = 46;
            this.comboBoxAracListeleMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxAracListeleMarka_SelectedIndexChanged);
            // 
            // buttonAracListeleCikis
            // 
            this.buttonAracListeleCikis.Image = ((System.Drawing.Image)(resources.GetObject("buttonAracListeleCikis.Image")));
            this.buttonAracListeleCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAracListeleCikis.Location = new System.Drawing.Point(17, 416);
            this.buttonAracListeleCikis.Name = "buttonAracListeleCikis";
            this.buttonAracListeleCikis.Size = new System.Drawing.Size(65, 53);
            this.buttonAracListeleCikis.TabIndex = 45;
            this.buttonAracListeleCikis.Text = "Çıkış";
            this.buttonAracListeleCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAracListeleCikis.UseVisualStyleBackColor = true;
            this.buttonAracListeleCikis.Click += new System.EventHandler(this.buttonAracListeleCikis_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Durum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Ücret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Kilometre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Plaka";
            // 
            // buttonAracSil
            // 
            this.buttonAracSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonAracSil.Image")));
            this.buttonAracSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAracSil.Location = new System.Drawing.Point(103, 416);
            this.buttonAracSil.Name = "buttonAracSil";
            this.buttonAracSil.Size = new System.Drawing.Size(77, 53);
            this.buttonAracSil.TabIndex = 55;
            this.buttonAracSil.Text = "Araç Sil";
            this.buttonAracSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAracSil.UseVisualStyleBackColor = true;
            this.buttonAracSil.Click += new System.EventHandler(this.buttonMusteriSil_Click);
            // 
            // buttonMusteriGuncelle
            // 
            this.buttonMusteriGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("buttonMusteriGuncelle.Image")));
            this.buttonMusteriGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMusteriGuncelle.Location = new System.Drawing.Point(197, 416);
            this.buttonMusteriGuncelle.Name = "buttonMusteriGuncelle";
            this.buttonMusteriGuncelle.Size = new System.Drawing.Size(78, 53);
            this.buttonMusteriGuncelle.TabIndex = 56;
            this.buttonMusteriGuncelle.Text = "Güncelle";
            this.buttonMusteriGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMusteriGuncelle.UseVisualStyleBackColor = true;
            this.buttonMusteriGuncelle.Click += new System.EventHandler(this.buttonMusteriGuncelle_Click);
            // 
            // FormAracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 485);
            this.Controls.Add(this.buttonMusteriGuncelle);
            this.Controls.Add(this.buttonAracSil);
            this.Controls.Add(this.textBoxAracListeleUcret);
            this.Controls.Add(this.textBoxAracListeleKilometre);
            this.Controls.Add(this.textBoxAracListeleRenk);
            this.Controls.Add(this.textBoxAracListelePlaka);
            this.Controls.Add(this.textBoxAracListeleModel);
            this.Controls.Add(this.comboBoxAracListeleDurum);
            this.Controls.Add(this.comboBoxAracListeleYakıt);
            this.Controls.Add(this.comboBoxAracListeleSeri);
            this.Controls.Add(this.comboBoxAracListeleMarka);
            this.Controls.Add(this.buttonAracListeleCikis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAracListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listesi";
            this.Load += new System.EventHandler(this.FormAracListesi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxAracListeleUcret;
        private System.Windows.Forms.TextBox textBoxAracListeleKilometre;
        private System.Windows.Forms.TextBox textBoxAracListeleRenk;
        private System.Windows.Forms.TextBox textBoxAracListelePlaka;
        private System.Windows.Forms.TextBox textBoxAracListeleModel;
        private System.Windows.Forms.ComboBox comboBoxAracListeleDurum;
        private System.Windows.Forms.ComboBox comboBoxAracListeleYakıt;
        private System.Windows.Forms.ComboBox comboBoxAracListeleSeri;
        private System.Windows.Forms.ComboBox comboBoxAracListeleMarka;
        private System.Windows.Forms.Button buttonAracListeleCikis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAracSil;
        private System.Windows.Forms.Button buttonMusteriGuncelle;
    }
}
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.dtDogum = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.picBurc = new System.Windows.Forms.PictureBox();
            this.burc = new System.Windows.Forms.Label();
            this.Ibl = new System.Windows.Forms.Label();
            this.burc1 = new System.Windows.Forms.Label();
            this.Ibl1 = new System.Windows.Forms.Label();
            this.burc2 = new System.Windows.Forms.Label();
            this.Ibl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBurc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Boy (cm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kilo(kg)";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(226, 65);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(226, 108);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(226, 184);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 22);
            this.txtBoy.TabIndex = 8;
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(226, 224);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(100, 22);
            this.txtKilo.TabIndex = 9;
            // 
            // dtDogum
            // 
            this.dtDogum.Location = new System.Drawing.Point(226, 146);
            this.dtDogum.Name = "dtDogum";
            this.dtDogum.Size = new System.Drawing.Size(200, 22);
            this.dtDogum.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet ve Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // picBurc
            // 
            this.picBurc.Location = new System.Drawing.Point(120, 315);
            this.picBurc.Name = "picBurc";
            this.picBurc.Size = new System.Drawing.Size(100, 50);
            this.picBurc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBurc.TabIndex = 12;
            this.picBurc.TabStop = false;
            // 
            // burc
            // 
            this.burc.AutoSize = true;
            this.burc.Location = new System.Drawing.Point(318, 315);
            this.burc.Name = "burc";
            this.burc.Size = new System.Drawing.Size(64, 16);
            this.burc.TabIndex = 13;
            this.burc.Text = "Burcunuz:";
            this.burc.Click += new System.EventHandler(this.label6_Click);
            // 
            // Ibl
            // 
            this.Ibl.AutoSize = true;
            this.Ibl.Location = new System.Drawing.Point(318, 381);
            this.Ibl.Name = "Ibl";
            this.Ibl.Size = new System.Drawing.Size(143, 16);
            this.Ibl.TabIndex = 14;
            this.Ibl.Text = "Vücut Kütle Endeksiniz:";
            // 
            // burc1
            // 
            this.burc1.AutoSize = true;
            this.burc1.Location = new System.Drawing.Point(388, 315);
            this.burc1.Name = "burc1";
            this.burc1.Size = new System.Drawing.Size(0, 16);
            this.burc1.TabIndex = 15;
            this.burc1.Click += new System.EventHandler(this.burcYorum_Click);
            // 
            // Ibl1
            // 
            this.Ibl1.AutoSize = true;
            this.Ibl1.Location = new System.Drawing.Point(467, 381);
            this.Ibl1.Name = "Ibl1";
            this.Ibl1.Size = new System.Drawing.Size(0, 16);
            this.Ibl1.TabIndex = 16;
            // 
            // burc2
            // 
            this.burc2.AutoSize = true;
            this.burc2.Location = new System.Drawing.Point(318, 331);
            this.burc2.Name = "burc2";
            this.burc2.Size = new System.Drawing.Size(0, 16);
            this.burc2.TabIndex = 17;
            // 
            // Ibl2
            // 
            this.Ibl2.AutoSize = true;
            this.Ibl2.Location = new System.Drawing.Point(321, 401);
            this.Ibl2.Name = "Ibl2";
            this.Ibl2.Size = new System.Drawing.Size(0, 16);
            this.Ibl2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.Ibl2);
            this.Controls.Add(this.burc2);
            this.Controls.Add(this.Ibl1);
            this.Controls.Add(this.burc1);
            this.Controls.Add(this.Ibl);
            this.Controls.Add(this.burc);
            this.Controls.Add(this.picBurc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtDogum);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBurc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.DateTimePicker dtDogum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBurc;
        private System.Windows.Forms.Label burc;
        private System.Windows.Forms.Label Ibl;
        private System.Windows.Forms.Label burc1;
        private System.Windows.Forms.Label Ibl1;
        private System.Windows.Forms.Label burc2;
        private System.Windows.Forms.Label Ibl2;
    }
}


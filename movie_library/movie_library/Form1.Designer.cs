
namespace movie_library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilmLink = new System.Windows.Forms.TextBox();
            this.txtFilmDırector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFilmTime = new System.Windows.Forms.TextBox();
            this.txtFilmKategori = new System.Windows.Forms.TextBox();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblfragman = new System.Windows.Forms.LinkLabel();
            this.lblFilmId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_SagListele = new System.Windows.Forms.Button();
            this.btn_SolListele = new System.Windows.Forms.Button();
            this.lbldirector = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFilmLink);
            this.panel1.Controls.Add(this.txtFilmDırector);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtFilmTime);
            this.panel1.Controls.Add(this.txtFilmKategori);
            this.panel1.Controls.Add(this.txtFilmAd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(25, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 284);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Film Yönetmeni ";
            // 
            // txtFilmLink
            // 
            this.txtFilmLink.Location = new System.Drawing.Point(115, 172);
            this.txtFilmLink.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilmLink.Name = "txtFilmLink";
            this.txtFilmLink.Size = new System.Drawing.Size(76, 20);
            this.txtFilmLink.TabIndex = 15;
            // 
            // txtFilmDırector
            // 
            this.txtFilmDırector.Location = new System.Drawing.Point(115, 132);
            this.txtFilmDırector.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilmDırector.Name = "txtFilmDırector";
            this.txtFilmDırector.Size = new System.Drawing.Size(76, 20);
            this.txtFilmDırector.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Film Süresi ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(32, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Film Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFilmTime
            // 
            this.txtFilmTime.Location = new System.Drawing.Point(115, 98);
            this.txtFilmTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilmTime.Name = "txtFilmTime";
            this.txtFilmTime.Size = new System.Drawing.Size(76, 20);
            this.txtFilmTime.TabIndex = 8;
            // 
            // txtFilmKategori
            // 
            this.txtFilmKategori.Location = new System.Drawing.Point(115, 54);
            this.txtFilmKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilmKategori.Name = "txtFilmKategori";
            this.txtFilmKategori.Size = new System.Drawing.Size(76, 20);
            this.txtFilmKategori.TabIndex = 7;
            this.txtFilmKategori.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(115, 23);
            this.txtFilmAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(76, 20);
            this.txtFilmAd.TabIndex = 6;
            this.txtFilmAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fragman";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Adı ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.lblfragman);
            this.panel2.Controls.Add(this.lblFilmId);
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btn_SagListele);
            this.panel2.Controls.Add(this.btn_SolListele);
            this.panel2.Controls.Add(this.lbldirector);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblKategori);
            this.panel2.Controls.Add(this.lblAd);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(266, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 290);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblfragman
            // 
            this.lblfragman.AutoSize = true;
            this.lblfragman.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblfragman.Location = new System.Drawing.Point(109, 179);
            this.lblfragman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfragman.Name = "lblfragman";
            this.lblfragman.Size = new System.Drawing.Size(10, 13);
            this.lblfragman.TabIndex = 29;
            this.lblfragman.TabStop = true;
            this.lblfragman.Text = "-";
            this.lblfragman.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblfragman_LinkClicked);
            // 
            // lblFilmId
            // 
            this.lblFilmId.AutoSize = true;
            this.lblFilmId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFilmId.Location = new System.Drawing.Point(109, 7);
            this.lblFilmId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilmId.Name = "lblFilmId";
            this.lblFilmId.Size = new System.Drawing.Size(12, 15);
            this.lblFilmId.TabIndex = 28;
            this.lblFilmId.Text = "-";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 6);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 13);
            this.lblId.TabIndex = 27;
            this.lblId.Text = "Film ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fragman";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Linen;
            this.btnGuncelle.Location = new System.Drawing.Point(162, 244);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 33);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Linen;
            this.btnSil.Location = new System.Drawing.Point(68, 244);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 33);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Linen;
            this.button5.Location = new System.Drawing.Point(191, 212);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 27);
            this.button5.TabIndex = 21;
            this.button5.Text = "Son >>";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Location = new System.Drawing.Point(69, 212);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 27);
            this.button4.TabIndex = 20;
            this.button4.Text = "<< İlk";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Form1_Load);
            // 
            // btn_SagListele
            // 
            this.btn_SagListele.BackColor = System.Drawing.Color.Linen;
            this.btn_SagListele.Location = new System.Drawing.Point(162, 212);
            this.btn_SagListele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SagListele.Name = "btn_SagListele";
            this.btn_SagListele.Size = new System.Drawing.Size(25, 27);
            this.btn_SagListele.TabIndex = 20;
            this.btn_SagListele.Text = ">";
            this.btn_SagListele.UseVisualStyleBackColor = false;
            this.btn_SagListele.Click += new System.EventHandler(this.btn_SagListele_Click);
            // 
            // btn_SolListele
            // 
            this.btn_SolListele.BackColor = System.Drawing.Color.Linen;
            this.btn_SolListele.Location = new System.Drawing.Point(121, 212);
            this.btn_SolListele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SolListele.Name = "btn_SolListele";
            this.btn_SolListele.Size = new System.Drawing.Size(25, 27);
            this.btn_SolListele.TabIndex = 19;
            this.btn_SolListele.Text = "<";
            this.btn_SolListele.UseVisualStyleBackColor = false;
            this.btn_SolListele.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbldirector
            // 
            this.lbldirector.AutoSize = true;
            this.lbldirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldirector.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbldirector.Location = new System.Drawing.Point(109, 143);
            this.lbldirector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldirector.Name = "lbldirector";
            this.lbldirector.Size = new System.Drawing.Size(12, 15);
            this.lbldirector.TabIndex = 16;
            this.lbldirector.Text = "-";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(109, 106);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(12, 15);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "-";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblKategori.Location = new System.Drawing.Point(109, 65);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(12, 15);
            this.lblKategori.TabIndex = 14;
            this.lblKategori.Text = "-";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAd.Location = new System.Drawing.Point(109, 32);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(12, 15);
            this.lblAd.TabIndex = 13;
            this.lblAd.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Film Yönetmeni ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Film Süresi ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 65);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Film Türü ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Film Adı ";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(563, 15);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(394, 285);
            this.webBrowser1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(316, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Film Önerileri için Lütfen Tıklayınız...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(972, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilmTime;
        private System.Windows.Forms.TextBox txtFilmKategori;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbldirector;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_SolListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_SagListele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilmLink;
        private System.Windows.Forms.TextBox txtFilmDırector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFilmId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.LinkLabel lblfragman;
        private System.Windows.Forms.Button button2;
    }
}


namespace SondersGP
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
            this.katilimciEkleButon = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cekilisYapButon = new System.Windows.Forms.Button();
            this.degerlerButon = new System.Windows.Forms.Button();
            this.kazananGosterButon = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // katilimciEkleButon
            // 
            this.katilimciEkleButon.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.katilimciEkleButon.Location = new System.Drawing.Point(318, 223);
            this.katilimciEkleButon.Name = "katilimciEkleButon";
            this.katilimciEkleButon.Size = new System.Drawing.Size(159, 96);
            this.katilimciEkleButon.TabIndex = 10;
            this.katilimciEkleButon.Text = "Katılımcı Ekle";
            this.katilimciEkleButon.UseVisualStyleBackColor = true;
            this.katilimciEkleButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(95, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 211);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(513, 131);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 211);
            this.listBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Katılımcılar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(527, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kazananlar";
            // 
            // cekilisYapButon
            // 
            this.cekilisYapButon.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cekilisYapButon.Location = new System.Drawing.Point(318, 325);
            this.cekilisYapButon.Name = "cekilisYapButon";
            this.cekilisYapButon.Size = new System.Drawing.Size(159, 96);
            this.cekilisYapButon.TabIndex = 5;
            this.cekilisYapButon.Text = "Çekiliş Yap";
            this.cekilisYapButon.UseVisualStyleBackColor = true;
            this.cekilisYapButon.Click += new System.EventHandler(this.button2_Click);
            // 
            // degerlerButon
            // 
            this.degerlerButon.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degerlerButon.Location = new System.Drawing.Point(318, 34);
            this.degerlerButon.Name = "degerlerButon";
            this.degerlerButon.Size = new System.Drawing.Size(159, 70);
            this.degerlerButon.TabIndex = 13;
            this.degerlerButon.Text = "Lütfen Seçiniz :\r\n-Kazanan Sayısı\r\n-Çıkış Değeri\r\n";
            this.degerlerButon.UseVisualStyleBackColor = true;
            this.degerlerButon.Click += new System.EventHandler(this.button3_Click);
            // 
            // kazananGosterButon
            // 
            this.kazananGosterButon.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kazananGosterButon.Location = new System.Drawing.Point(304, 121);
            this.kazananGosterButon.Name = "kazananGosterButon";
            this.kazananGosterButon.Size = new System.Drawing.Size(190, 96);
            this.kazananGosterButon.TabIndex = 14;
            this.kazananGosterButon.Text = "Kazananları Göster";
            this.kazananGosterButon.UseVisualStyleBackColor = true;
            this.kazananGosterButon.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(513, 131);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(188, 212);
            this.listBox3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 448);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.kazananGosterButon);
            this.Controls.Add(this.degerlerButon);
            this.Controls.Add(this.katilimciEkleButon);
            this.Controls.Add(this.cekilisYapButon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button katilimciEkleButon;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cekilisYapButon;
        private System.Windows.Forms.Button degerlerButon;
        private System.Windows.Forms.Button kazananGosterButon;
        private System.Windows.Forms.ListBox listBox3;
    }
}


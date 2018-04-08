namespace Klasör_Kilitleyici
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
            this.btnAc = new System.Windows.Forms.Button();
            this.btnKilit = new System.Windows.Forms.Button();
            this.btnKaldir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(179, 33);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 23);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Aç...";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnKilit
            // 
            this.btnKilit.Location = new System.Drawing.Point(6, 78);
            this.btnKilit.Name = "btnKilit";
            this.btnKilit.Size = new System.Drawing.Size(75, 23);
            this.btnKilit.TabIndex = 1;
            this.btnKilit.Text = "Kilitle";
            this.btnKilit.UseVisualStyleBackColor = true;
            this.btnKilit.Click += new System.EventHandler(this.btnKilit_Click);
            // 
            // btnKaldir
            // 
            this.btnKaldir.Location = new System.Drawing.Point(98, 78);
            this.btnKaldir.Name = "btnKaldir";
            this.btnKaldir.Size = new System.Drawing.Size(75, 23);
            this.btnKaldir.TabIndex = 2;
            this.btnKaldir.Text = "Kilidi Kaldır";
            this.btnKaldir.UseVisualStyleBackColor = true;
            this.btnKaldir.Click += new System.EventHandler(this.btnKaldir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnKaldir);
            this.groupBox1.Controls.Add(this.btnAc);
            this.groupBox1.Controls.Add(this.btnKilit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifreleme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Klasör Erişim Engelleyici";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnKilit;
        private System.Windows.Forms.Button btnKaldir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


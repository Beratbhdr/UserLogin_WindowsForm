namespace KullanıcıGiris
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_usercode = new System.Windows.Forms.TextBox();
            this.txt_passcode = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.check_hatırla = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_usercode
            // 
            this.txt_usercode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_usercode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usercode.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usercode.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_usercode.Location = new System.Drawing.Point(590, 110);
            this.txt_usercode.Name = "txt_usercode";
            this.txt_usercode.Size = new System.Drawing.Size(175, 22);
            this.txt_usercode.TabIndex = 1;
            this.txt_usercode.Text = "Enter Your Name";
            // 
            // txt_passcode
            // 
            this.txt_passcode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_passcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_passcode.Location = new System.Drawing.Point(592, 154);
            this.txt_passcode.Name = "txt_passcode";
            this.txt_passcode.Size = new System.Drawing.Size(175, 20);
            this.txt_passcode.TabIndex = 2;
            this.txt_passcode.Text = "Enter Your Password";
            // 
            // txt_username
            // 
            this.txt_username.AutoSize = true;
            this.txt_username.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_username.Location = new System.Drawing.Point(510, 114);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(74, 13);
            this.txt_username.TabIndex = 3;
            this.txt_username.Text = "USERNAME :";
            // 
            // txt_password
            // 
            this.txt_password.AutoSize = true;
            this.txt_password.Location = new System.Drawing.Point(510, 157);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(76, 13);
            this.txt_password.TabIndex = 4;
            this.txt_password.Text = "PASSWORD :";
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_giris.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_giris.Location = new System.Drawing.Point(513, 191);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(254, 30);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // check_hatırla
            // 
            this.check_hatırla.AutoSize = true;
            this.check_hatırla.Checked = true;
            this.check_hatırla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_hatırla.Location = new System.Drawing.Point(513, 236);
            this.check_hatırla.Name = "check_hatırla";
            this.check_hatırla.Size = new System.Drawing.Size(100, 17);
            this.check_hatırla.TabIndex = 6;
            this.check_hatırla.Text = "BENİ HATIRLA";
            this.check_hatırla.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "WİNDOWS FORM / KULLANCI GİRİŞ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_hatırla);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_passcode);
            this.Controls.Add(this.txt_usercode);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_usercode;
        private System.Windows.Forms.TextBox txt_passcode;
        private System.Windows.Forms.Label txt_username;
        private System.Windows.Forms.Label txt_password;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.CheckBox check_hatırla;
        private System.Windows.Forms.Label label1;
    }
}


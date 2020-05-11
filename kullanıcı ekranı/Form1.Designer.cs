namespace kullanıcı_ekranı
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
            this.button = new Bunifu.Framework.UI.BunifuTileButton();
            this.text1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonimage1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonimage1)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button.color = System.Drawing.SystemColors.MenuHighlight;
            this.button.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.ImagePosition = 20;
            this.button.ImageZoom = 50;
            this.button.LabelPosition = 41;
            this.button.LabelText = "Giriş";
            this.button.Location = new System.Drawing.Point(85, 159);
            this.button.Margin = new System.Windows.Forms.Padding(6);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(128, 129);
            this.button.TabIndex = 4;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // text1
            // 
            this.text1.BorderColorFocused = System.Drawing.Color.MediumSeaGreen;
            this.text1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text1.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.text1.BorderThickness = 3;
            this.text1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text1.isPassword = false;
            this.text1.Location = new System.Drawing.Point(13, 49);
            this.text1.Margin = new System.Windows.Forms.Padding(4);
            this.text1.MaxLength = 32767;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(270, 48);
            this.text1.TabIndex = 8;
            this.text1.Text = "Kullanıcı Adınız";
            this.text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text1.Click += new System.EventHandler(this.text1_Click);
            this.text1.Enter += new System.EventHandler(this.text1_Enter);
            // 
            // text2
            // 
            this.text2.BorderColorFocused = System.Drawing.Color.MediumSeaGreen;
            this.text2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text2.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.text2.BorderThickness = 3;
            this.text2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text2.isPassword = true;
            this.text2.Location = new System.Drawing.Point(13, 105);
            this.text2.Margin = new System.Windows.Forms.Padding(4);
            this.text2.MaxLength = 32767;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(270, 44);
            this.text2.TabIndex = 9;
            this.text2.Text = "Şifreniz";
            this.text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text2.Click += new System.EventHandler(this.text2_Click);
            this.text2.Enter += new System.EventHandler(this.text2_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.buttonimage1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 33);
            this.panel1.TabIndex = 10;
            // 
            // buttonimage1
            // 
            this.buttonimage1.Image = ((System.Drawing.Image)(resources.GetObject("buttonimage1.Image")));
            this.buttonimage1.ImageActive = null;
            this.buttonimage1.Location = new System.Drawing.Point(270, 0);
            this.buttonimage1.Name = "buttonimage1";
            this.buttonimage1.Size = new System.Drawing.Size(26, 33);
            this.buttonimage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonimage1.TabIndex = 26;
            this.buttonimage1.TabStop = false;
            this.buttonimage1.Zoom = 10;
            this.buttonimage1.Click += new System.EventHandler(this.buttonimage1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(68, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(162, 24);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Kullanıcı Ekranı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 297);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 51);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "superadmin girisi için   id: omer sifre :1\r\nadmin girişi için            id:cagla" +
    "r sifre:2\r\nkullanıcı girişi için        id:dursun sifre:3\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(300, 352);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonimage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton button;
        private Bunifu.Framework.UI.BunifuMetroTextbox text2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox text1;
        private Bunifu.Framework.UI.BunifuImageButton buttonimage1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


namespace kullanıcı_ekranı
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.basarılı = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttongiris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.icon = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFormFadeTransition2 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // basarılı
            // 
            this.basarılı.AutoSize = true;
            this.basarılı.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.basarılı.ForeColor = System.Drawing.Color.SeaGreen;
            this.basarılı.Location = new System.Drawing.Point(60, 247);
            this.basarılı.Name = "basarılı";
            this.basarılı.Size = new System.Drawing.Size(103, 33);
            this.basarılı.TabIndex = 16;
            this.basarılı.Text = "Basarılı";
            // 
            // buttongiris
            // 
            this.buttongiris.Active = false;
            this.buttongiris.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttongiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttongiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttongiris.BorderRadius = 0;
            this.buttongiris.ButtonText = "Devam Et";
            this.buttongiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttongiris.DisabledColor = System.Drawing.Color.Gray;
            this.buttongiris.Iconcolor = System.Drawing.Color.Transparent;
            this.buttongiris.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttongiris.Iconimage")));
            this.buttongiris.Iconimage_right = null;
            this.buttongiris.Iconimage_right_Selected = null;
            this.buttongiris.Iconimage_Selected = null;
            this.buttongiris.IconMarginLeft = 0;
            this.buttongiris.IconMarginRight = 0;
            this.buttongiris.IconRightVisible = true;
            this.buttongiris.IconRightZoom = 0D;
            this.buttongiris.IconVisible = true;
            this.buttongiris.IconZoom = 90D;
            this.buttongiris.IsTab = false;
            this.buttongiris.Location = new System.Drawing.Point(36, 294);
            this.buttongiris.Name = "buttongiris";
            this.buttongiris.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttongiris.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttongiris.OnHoverTextColor = System.Drawing.Color.White;
            this.buttongiris.selected = false;
            this.buttongiris.Size = new System.Drawing.Size(165, 38);
            this.buttongiris.TabIndex = 15;
            this.buttongiris.Text = "Devam Et";
            this.buttongiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttongiris.Textcolor = System.Drawing.Color.White;
            this.buttongiris.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttongiris.Visible = false;
            this.buttongiris.Click += new System.EventHandler(this.buttongiris_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.WindowText;
            this.icon.Enabled = false;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(37, 59);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(165, 181);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 14;
            this.icon.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 100;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "BÜ CRM\'e Hoşgeldiniz";
            // 
            // bunifuFormFadeTransition2
            // 
            this.bunifuFormFadeTransition2.Delay = 1;
            this.bunifuFormFadeTransition2.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition2_TransitionEnd);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(233, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basarılı);
            this.Controls.Add(this.buttongiris);
            this.Controls.Add(this.icon);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel basarılı;
        private Bunifu.Framework.UI.BunifuFlatButton buttongiris;
        private System.Windows.Forms.PictureBox icon;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition2;
    }
}
namespace kullanıcı_ekranı
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonimage1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonflat1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.text2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.datagrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonimage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.buttonimage1);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 45);
            this.panel1.TabIndex = 21;
            // 
            // buttonimage1
            // 
            this.buttonimage1.Image = ((System.Drawing.Image)(resources.GetObject("buttonimage1.Image")));
            this.buttonimage1.ImageActive = null;
            this.buttonimage1.Location = new System.Drawing.Point(545, 7);
            this.buttonimage1.Name = "buttonimage1";
            this.buttonimage1.Size = new System.Drawing.Size(46, 35);
            this.buttonimage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonimage1.TabIndex = 27;
            this.buttonimage1.TabStop = false;
            this.buttonimage1.Zoom = 10;
            this.buttonimage1.Click += new System.EventHandler(this.buttonimage1_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(185, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(221, 24);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Kullanıcı Silme Ekranı";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(66, 118);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(80, 24);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Yetkisi :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(5, 67);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(141, 24);
            this.bunifuCustomLabel1.TabIndex = 39;
            this.bunifuCustomLabel1.Text = "Kullanıcı Adı:";
            // 
            // buttonflat1
            // 
            this.buttonflat1.Active = false;
            this.buttonflat1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonflat1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonflat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonflat1.BorderRadius = 0;
            this.buttonflat1.ButtonText = "Silme";
            this.buttonflat1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonflat1.DisabledColor = System.Drawing.Color.Gray;
            this.buttonflat1.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.buttonflat1.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonflat1.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonflat1.Iconimage")));
            this.buttonflat1.Iconimage_right = null;
            this.buttonflat1.Iconimage_right_Selected = null;
            this.buttonflat1.Iconimage_Selected = null;
            this.buttonflat1.IconMarginLeft = 0;
            this.buttonflat1.IconMarginRight = 0;
            this.buttonflat1.IconRightVisible = true;
            this.buttonflat1.IconRightZoom = 0D;
            this.buttonflat1.IconVisible = true;
            this.buttonflat1.IconZoom = 90D;
            this.buttonflat1.IsTab = false;
            this.buttonflat1.Location = new System.Drawing.Point(151, 163);
            this.buttonflat1.Margin = new System.Windows.Forms.Padding(6);
            this.buttonflat1.Name = "buttonflat1";
            this.buttonflat1.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonflat1.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.buttonflat1.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonflat1.selected = false;
            this.buttonflat1.Size = new System.Drawing.Size(183, 43);
            this.buttonflat1.TabIndex = 38;
            this.buttonflat1.Text = "Silme";
            this.buttonflat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonflat1.Textcolor = System.Drawing.Color.White;
            this.buttonflat1.TextFont = new System.Drawing.Font("Century Gothic", 12.75F);
            this.buttonflat1.Click += new System.EventHandler(this.buttonflat1_Click);
            // 
            // text2
            // 
            this.text2.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.text2.BorderColorIdle = System.Drawing.Color.MediumSeaGreen;
            this.text2.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.text2.BorderThickness = 3;
            this.text2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text2.Enabled = false;
            this.text2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text2.isPassword = false;
            this.text2.Location = new System.Drawing.Point(153, 108);
            this.text2.Margin = new System.Windows.Forms.Padding(4);
            this.text2.MaxLength = 32767;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(183, 44);
            this.text2.TabIndex = 37;
            this.text2.Text = " ";
            this.text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text1
            // 
            this.text1.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight;
            this.text1.BorderColorIdle = System.Drawing.Color.MediumSeaGreen;
            this.text1.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight;
            this.text1.BorderThickness = 3;
            this.text1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text1.Enabled = false;
            this.text1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text1.isPassword = false;
            this.text1.Location = new System.Drawing.Point(153, 56);
            this.text1.Margin = new System.Windows.Forms.Padding(4);
            this.text1.MaxLength = 32767;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(183, 44);
            this.text1.TabIndex = 36;
            this.text1.Text = " ";
            this.text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datagrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid1.DoubleBuffered = true;
            this.datagrid1.EnableHeadersVisualStyles = false;
            this.datagrid1.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.datagrid1.HeaderBgColor = System.Drawing.Color.MediumSeaGreen;
            this.datagrid1.HeaderForeColor = System.Drawing.Color.MediumSeaGreen;
            this.datagrid1.Location = new System.Drawing.Point(343, 56);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.ReadOnly = true;
            this.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid1.Size = new System.Drawing.Size(260, 161);
            this.datagrid1.TabIndex = 35;
            this.datagrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid1_CellClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(687, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 31;
            this.textBox3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Visible = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(603, 221);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonflat1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.datagrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonimage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton buttonimage1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonflat1;
        private Bunifu.Framework.UI.BunifuMetroTextbox text2;
        private Bunifu.Framework.UI.BunifuMetroTextbox text1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
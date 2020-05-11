using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanıcı_ekranı
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            icon.Enabled = false;
            buttongiris.Visible = true;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition2.ShowAsyc(this);
        }
        Form1 f1 = new Form1();
        private void buttongiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
            
        }
        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void bunifuFormFadeTransition2_TransitionEnd(object sender, EventArgs e)
        {
            timer1.Start();
            icon.Enabled = true;
        }
    }
}

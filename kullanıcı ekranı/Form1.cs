using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace kullanıcı_ekranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;      
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kullanici.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where k_ad='" + text1.Text + "' AND k_sifre='" + text2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 f2 = new Form2();
                Form6 f6 = new Form6();
                if (dr["yetki"].ToString() == "superadmin")
                {
                    f2.label5.Text = "Kullanıcı: "+ this.text1.Text;
                    f2.Show();
                    this.Hide();
                }
                else if (dr["yetki"].ToString() == "admin")
                {
                    f2.label5.Text = "Kullanıcı: " + this.text1.Text;
                    f2.şifreDeğiştirToolStripMenuItem.Enabled = false;
                    f2.yetkilendirYetkiDeğiştirToolStripMenuItem.Enabled = false;
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    f2.label5.Text = "Kullanıcı: " + this.text1.Text;
                    f2.ayarlar.Enabled = false;
                    f2.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }
            con.Close();
        }

        private void text1_Enter(object sender, EventArgs e)
        {
            text1.Text = "Kullanıcı Adınız";
        }


        private void text1_Click(object sender, EventArgs e)
        {
            text1.Text = "";
        }

        private void text2_Click(object sender, EventArgs e)
        {
            text2.Text = "";
        }

        private void text2_Enter(object sender, EventArgs e)
        {
            text2.Text = "şifreniz";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            text1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonimage1_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Programı Kapatılacak Emin Misin ? ", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes) Application.Exit();
        }
    }
}

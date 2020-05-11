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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kullanici.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();


        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in datagrid1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBox1.Text = row.Cells["k_no"].Value.ToString();
                text1.Text = row.Cells["k_ad"].Value.ToString();
                textBox3.Text = row.Cells["k_sifre"].Value.ToString();
                text2.Text = row.Cells["yetki"].Value.ToString();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kullanici", baglanti);

            dtst.Clear();
            adtr.Fill(dtst, "kullanici");

            datagrid1.DataSource = dtst.Tables["kullanici"];
            datagrid1.Columns[0].Visible = false;
            datagrid1.Columns[2].Visible = false;

            adtr.Dispose();

            baglanti.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            text2.Text = "superadmin";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            text2.Text = "admin";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            text2.Text = "kullanıcı";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            button3_Click(sender, e);
        }

        private void buttonflat1_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Yetki Değiştirilecek Emin Misin ? ", "Yetki Değiştirme Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                komut.Connection = baglanti;
                komut.CommandText = "Update kullanici set k_no='" + textBox1.Text + "',k_ad='" + text1.Text + "',k_sifre='" + textBox3.Text + "',yetki='" + text2.Text + "' where [k_no]='" + textBox1.Text + "'";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                button2_Click(sender, e);
                MessageBox.Show("Kayıt Güncellendi!");
            }
               
        }

        private void Form4_FontChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Enter(object sender, EventArgs e)
        {
            
        }
        Form2 f2 = new Form2();
        private void buttonimage1_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }
    }
}

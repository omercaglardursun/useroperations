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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kullanici.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kullanici", baglanti);
          
            dtst.Clear();
            adtr.Fill(dtst, "kullanici");

            datagrid1.DataSource = dtst.Tables["kullanici"];
            datagrid1.Columns[0].Visible = false;
            datagrid1.Columns[3].Visible = false;

            adtr.Dispose();

            baglanti.Close();
        }

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
                text2.Text = row.Cells["k_sifre"].Value.ToString();
                textBox4.Text = row.Cells["yetki"].Value.ToString();
               
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void datagrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void buttonflat1_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Şifre Değiştirilecek Emin Misin ? ", "Şifre Değiştirme Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                komut.Connection = baglanti;
                komut.CommandText = "Update kullanici set k_no='" + textBox1.Text + "',k_ad='" + text1.Text + "',k_sifre='" + text2.Text + "',yetki='" + textBox4.Text + "' where [k_no]='" + textBox1.Text + "'";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                button2_Click(sender, e);
                MessageBox.Show("Kayıt Güncellendi!");
            }
        }
        Form2 f2 = new Form2();
        private void buttonimage1_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }
    }
}

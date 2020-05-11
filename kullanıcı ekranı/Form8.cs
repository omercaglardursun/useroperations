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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kullanici.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kullanici", baglanti);

            dtst.Clear();
            adtr.Fill(dtst, "kullanici");
            datagrid1.DataSource = dtst.Tables["kullanici"];
            adtr.Dispose();
            sayibutton1.Text = datagrid1.RowCount.ToString() + " Kullanıcıya Sahipsiniz";
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
                text3.Text = row.Cells["k_no"].Value.ToString();
                text1.Text = row.Cells["k_ad"].Value.ToString();
                text4.Text = row.Cells["k_sifre"].Value.ToString();
                text2.Text = row.Cells["yetki"].Value.ToString();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                

            }
        }

        private void datagrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);
          
        }

        private void buttonflat1_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Kullanıcıyı Eklemeye Emin Misin ? ", "Kullanıcı Ekleme Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into kullanici(k_no,k_ad,k_sifre,yetki) Values ('" + text3.Text + "','" + text1.Text + "','" + text4.Text + "','" + text2.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                button2_Click(sender, e);
                MessageBox.Show("Kayıt Tamamlandı!");
                buttonflat1.Visible = false;
            }
                
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

        private void temizlebutton1_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            buttonflat1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonimage1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}

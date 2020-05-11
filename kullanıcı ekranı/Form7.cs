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
    public partial class Form7 : Form
    {
        public Form7()
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
            datagrid1.Columns[0].Visible = false;
            datagrid1.Columns[2].Visible = false;
            adtr.Dispose();
            baglanti.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);
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
                textBox3.Text = row.Cells["k_sifre"].Value.ToString();
                text2.Text = row.Cells["yetki"].Value.ToString();
            }
        }

        private void datagrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void buttonflat1_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Kullanıcıyı Silmeye Emin Misin ? ", "Kullanıcı Silme Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM kullanici WHERE [k_no] = '" + textBox1.Text.ToString() + "'", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                button2_Click(sender, e);
                MessageBox.Show("Veri Silindi", "Veri Gitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

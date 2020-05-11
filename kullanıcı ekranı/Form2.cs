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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kurum.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        Form1 f1 = new Form1();
        private void Form2_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void yetkilendirYetkiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void ayarlar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                label1.Text = DateTime.Now.ToString("ss");
                label2.Text = DateTime.Now.ToString("hh:mm");
                label3.Text = DateTime.Now.ToString("dddd");
                label4.Text = DateTime.Now.ToString("dd/M/yyyy");
                circleprogress1.Value = Convert.ToInt32(label1.Text);
            }
            catch (Exception) { return; }
        }

        private void Yardım_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void buttonimage1_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Programı Kapatılacak Emin Misin ? ", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes) Application.Exit();
        }

        private void buttonimage2_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Kullanıcı Değiştirmeye Emin Misin ? ", "Kullanıcı Değiştirme Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {

                f1.Show();
                this.Hide();
            }
        }
      
        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kurum", baglanti);

            dtst.Clear();
            adtr.Fill(dtst, "kurum");
            datagrid1.DataSource = dtst.Tables["kurum"];
            adtr.Dispose();
            sayibutton1.Text = datagrid1.RowCount.ToString() + " Firmaya Sahipsiniz";
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
                text1.Text = row.Cells["kurum_no"].Value.ToString();
                text2.Text = row.Cells["kurum_ad"].Value.ToString();
                text3.Text = row.Cells["kurum_website"].Value.ToString();
                text4.Text = row.Cells["kurum_tel"].Value.ToString();
                text5.Text = row.Cells["firma_adres"].Value.ToString();
            }
        }

        private void datagrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            text5.Text = "";
            buttonflat1.Enabled = true;
        }

        private void buttonflat1_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Kullanıcıyı Eklemeye Emin Misin ? ", "Kullanıcı Ekleme Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into kurum(kurum_no,kurum_ad,kurum_website,kurum_tel,firma_adres) Values ('" + text1.Text + "','" + text2.Text + "','" + text3.Text + "','" + text4.Text + "','" + text5.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                button2_Click(sender, e);
                MessageBox.Show("Kayıt Tamamlandı!");
                buttonflat1.Enabled = false;
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonflat2.Enabled = true;
        }

        private void buttonflat2_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Kayıt Değiştirilecek Emin Misin ? ", "Şifre Değiştirme Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                komut.Connection = baglanti;
                komut.CommandText = "Update kurum set kurum_no='" + text1.Text + "',kurum_ad='" + text2.Text + "',kurum_website='" + text3.Text + "',kurum_tel='" + text4.Text + "',firma_adres='" + text5.Text + "' where [kurum_no]='" + text1.Text + "'";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                button2_Click(sender, e);
                MessageBox.Show("Kayıt Güncellendi!");
                buttonflat2.Enabled = false;
            }
        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void buttonresim1_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Kullanıcıyı Silmeye Emin Misin ? ", "Kullanıcı Silme Uyarısı!", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM kurum WHERE [kurum_no] = '" + text1.Text.ToString() + "'", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                button2_Click(sender, e);
                MessageBox.Show("Veri Silindi", "Veri Gitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonresim1.Enabled = false;
            }
        }

        private void buttonflat3_Click(object sender, EventArgs e)
        {
   

           
        }

        private void sayibutton1_Enter(object sender, EventArgs e)
        {
          
        }

        private void sayibutton1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void text6_OnValueChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                if (text6.Text.Trim() == "")
                {
                    dtst.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kurum", baglanti);
                    baglanti.Open();
                    adtr.Fill(dtst, "kurum");
                    datagrid1.DataSource = dtst.Tables["kurum"];
                    baglanti.Close();
                }
                else
                {
                    dtst.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kurum  where kurum_no like'" + text6.Text + "%'", baglanti);
                    baglanti.Close();
                    adtr.Fill(dtst, "kurum");
                    datagrid1.DataSource = dtst.Tables["kurum"];
                    baglanti.Close();
                }
            }
            else if (radioButton2.Checked==true)
            {
                if (text6.Text.Trim() == "")
                {
                    dtst.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kurum", baglanti);
                    baglanti.Open();
                    adtr.Fill(dtst, "kurum");
                    datagrid1.DataSource = dtst.Tables["kurum"];
                    baglanti.Close();
                }
                else
                {
                    dtst.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kurum  where kurum_ad like'" + text6.Text + "%' order by kurum_ad", baglanti);
                    baglanti.Close();
                    adtr.Fill(dtst, "kurum");
                    datagrid1.DataSource = dtst.Tables["kurum"];
                    baglanti.Close();
                }
            }
            else if (radioButton3.Checked==true)
            {
                if (text6.Text.Trim() == "")
                {
                    dtst.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kurum", baglanti);
                    baglanti.Open();
                    adtr.Fill(dtst, "kurum");
                    datagrid1.DataSource = dtst.Tables["kurum"];
                    baglanti.Close();
                }
                else
                {
                    dtst.Clear();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kurum  where kurum_tel like'" + text6.Text + "%' order by kurum_tel", baglanti);
                    baglanti.Close();
                    adtr.Fill(dtst, "kurum");
                    datagrid1.DataSource = dtst.Tables["kurum"];
                    baglanti.Close();
                }
            }
        }




    }
    }


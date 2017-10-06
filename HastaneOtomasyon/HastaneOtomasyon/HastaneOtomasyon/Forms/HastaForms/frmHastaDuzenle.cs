using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonDATA;
using HastaneOtomasyonLIB;


namespace HastaneOtomasyon.Forms.HastaForms
{
    public partial class frmHastaDuzenle : Form
    {
        public frmHastaDuzenle()
        {
            InitializeComponent();
        }
        HastaRepository hRepo = new HastaRepository();
        Hasta hst = new Hasta();
      
        private void getir()
        {
            dataGridView1.DataSource = hRepo.SelectAll();
        }
        private void kilitac()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            comboBox1.Enabled = true;
        }
        private void frmHastaDuzenle_Load(object sender, EventArgs e)
        {
            getir();
        }
        int seciliid;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seciliid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            hst = hRepo.SelectByID(seciliid);
            textBox1.Text = hst.HastaAd;
            textBox2.Text = hst.HastaSoyad;
            textBox3.Text = hst.HastaYas.ToString();
            comboBox1.Text = hst.KanGrubu;
            if (hst.Cinsiyet == "Erkek")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            kilitac();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cinsiyet;
                hst.HastaAd = textBox1.Text;
                hst.HastaSoyad = textBox2.Text;
                hst.HastaYas =Convert.ToInt32(textBox3.Text);
                hst.KanGrubu = comboBox1.Text;
                if (radioButton1.Checked==true)
                {
                    cinsiyet = "Erkek";
                    hst.Cinsiyet = cinsiyet;
                }
                else
                {
                    cinsiyet = "Kadın";
                    hst.Cinsiyet = cinsiyet;
                }
                hst.DTarih = DateTime.Now.AddYears(-Convert.ToInt32(textBox3.Text));
                hRepo.Update(hst);
                MessageBox.Show("Düzenleme Başarılı");
                getir();
            }
            catch (Exception)
            {

                MessageBox.Show("Hasta Kaydı Düzenlenemedi");
            }
        }
    }
}

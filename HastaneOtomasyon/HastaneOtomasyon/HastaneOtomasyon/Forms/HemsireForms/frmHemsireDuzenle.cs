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


namespace HastaneOtomasyon.Forms.HemsireForms
{
    public partial class frmHemsireDuzenle : Form
    {
        public frmHemsireDuzenle()
        {
            InitializeComponent();
        }
        HemsireRepository hemRepo = new HemsireRepository();
        Hemsire hem = new Hemsire();
        private void kilitac()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
        }
        private void cbBirimDoldur()
        {
            comboBox1.DataSource = hemRepo.SelectBirim().Select(x => new
            {
                x.BirimAd,
                x.BirimID
            }).ToList();
            comboBox1.DisplayMember = "BirimAd";
            comboBox1.ValueMember = "BirimID";
        }
        private void cbDoktorDoldur()
        {
            comboBox2.DataSource = hemRepo.SelectDoktor().Select(x => new
            {
                x.DoktorAd,
                x.DoktorID
            }).ToList();
            comboBox2.DisplayMember = "DoktorAd";
            comboBox2.ValueMember = "DoktorID";

        }
        private void getir() {
            dataGridView1.DataSource = hemRepo.SelectAll();
        }
        private void frmHemsireDuzenle_Load(object sender, EventArgs e)
        {
            cbBirimDoldur();
            cbDoktorDoldur();
            getir();
        }
        int seciliid;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                seciliid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                hem = hemRepo.SelectByID(seciliid);
                textBox1.Text = hem.HemsireAd;
                textBox2.Text = hem.HemsireSoyad;
                comboBox1.SelectedValue = hem.BirimID;
                comboBox2.SelectedValue = hem.DoktorID;
                kilitac();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Seçim işlemi başarısız");
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hem.HemsireAd = textBox1.Text;
                hem.HemsireSoyad = textBox2.Text;
                hem.BirimID = (int)comboBox1.SelectedValue;
                hem.DoktorID = (int)comboBox2.SelectedValue;
                hemRepo.Update(hem);
                MessageBox.Show("Güncelleme Başarılı");
                getir();
            }
            catch (Exception)
            {

                MessageBox.Show("İşlem Başarısız");
            }
               
        }
    }
}

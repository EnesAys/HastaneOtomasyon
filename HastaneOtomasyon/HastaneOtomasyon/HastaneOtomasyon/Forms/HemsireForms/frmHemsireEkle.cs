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
    public partial class frmHemsireEkle : Form
    {
        public frmHemsireEkle()
        {
            InitializeComponent();
        }
        HemsireRepository hemRepo = new HemsireRepository();
        Hemsire hem = new Hemsire();
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
            comboBox2.DataSource= hemRepo.SelectDoktor().Select(x => new
            {
                x.DoktorAd,
                x.DoktorID
            }).ToList();
            comboBox2.DisplayMember = "DoktorAd";
            comboBox2.ValueMember = "DoktorID";

        }
        private void temizle()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    txt.Clear();
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Text = "";
                }
            }
        }
        private void frmHemsireEkle_Load(object sender, EventArgs e)
        {
            cbBirimDoldur();
            cbDoktorDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hem.HemsireAd = textBox1.Text;
                hem.HemsireSoyad = textBox2.Text;
                hem.BirimID = (int)comboBox1.SelectedValue;
                hem.DoktorID = (int)comboBox2.SelectedValue;
                hemRepo.Insert(hem);
                MessageBox.Show("Kayıt Başarılı");
                temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Hemşire kaydedilemedi. Alanları Doldurduğunuzdan Emin OLun");
            }
         

        }
    }
}

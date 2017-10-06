using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonLIB;
using HastaneOtomasyonDATA;


namespace HastaneOtomasyon.Forms.HastaForms
{
    public partial class frmHastaEkle : Form
    {
        public frmHastaEkle()
        {
            InitializeComponent();
        }
        HastaRepository hRepo = new HastaRepository();
        Hasta hst = new Hasta();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hst.HastaAd = textBox1.Text;
                hst.HastaSoyad = textBox2.Text;
                hst.HastaYas = Convert.ToInt32(textBox3.Text);
                hst.DTarih = DateTime.Now.AddYears(-Convert.ToInt32(textBox3.Text));
                hst.KanGrubu = comboBox1.Text;
                string cinsiyet;
                if (radioButton1.Checked == true)
                {
                    cinsiyet = "Erkek";
                    hst.Cinsiyet = cinsiyet;
                }
                else
                {
                    cinsiyet = "Kadın";
                    hst.Cinsiyet = cinsiyet;
                }
                hRepo.Insert(hst);
                temizle();
                MessageBox.Show("Hasta Kaydedildi");
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Başarısız");
            }
            
        }

        private void frmHastaEkle_Load(object sender, EventArgs e)
        {

        }
    }
}

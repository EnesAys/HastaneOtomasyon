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


namespace HastaneOtomasyon.Forms.DoktorForms
{
    public partial class frmDoktorEkle : Form
    {
        public frmDoktorEkle()
        {
            InitializeComponent();
        }
        DoktorRepository drRepo = new DoktorRepository();
        Doktor dr = new Doktor();
        private void cbBirimDoldur()
        {
            cbDekleBirim.DataSource = drRepo.SelectBirim().Select(x => new
            {
                x.BirimAd,
                x.BirimID
            }).ToList();
            cbDekleBirim.DisplayMember = "BirimAd";
            cbDekleBirim.ValueMember = "BirimID";
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
        private void frmDoktorEkle_Load(object sender, EventArgs e)
        {
            cbBirimDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dr.DoktorAd = textBox1.Text;
                dr.DoktorSoyad = textBox2.Text;
                dr.BirimID = (int)cbDekleBirim.SelectedValue;
                dr.Maas = Convert.ToInt32(textBox3.Text);
                drRepo.Insert(dr);
                temizle();
                MessageBox.Show("Doktor kaydı gerçekleştirildi");
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Başarısız");
            }
          
        }
    }
}

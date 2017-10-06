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


namespace HastaneOtomasyon.Forms
{
    public partial class frmRandevu : Form
    {
        public frmRandevu()
        {
            InitializeComponent();
        }
        Randevu rnd = new Randevu();
        RandevuRepo rRepo = new RandevuRepo();
        private void getir()
        {
            dataGridView1.DataSource = rRepo.SelectAll();
        }
        private void Temizle()
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
                    ComboBox cb=(ComboBox)c;
                    cb.SelectedIndex =0;
                }
            }
        }
        private void cbBirimDoldur()
        {
            comboBox1.DataSource = rRepo.SelectBirim().Select(x => new
            {
                x.BirimAd,
                x.BirimID
            }).ToList();
            comboBox1.DisplayMember = "BirimAd";
            comboBox1.ValueMember = "BirimID";
        }

        private void cbHastaDoldur()
        {
            comboBox3.DataSource = rRepo.SelectHasta().Select(x => new
            {
                x.HastaAd,
                x.HastaID
            }).ToList();
            comboBox3.DisplayMember = "HastaAd";
            comboBox3.ValueMember = "HastaID";
        }

        private void frmRandevu_Load(object sender, EventArgs e)
        {
            cbBirimDoldur();
            cbHastaDoldur();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.DataSource = rRepo.SelectDoktor().Where(x => x.BirimID == (int)comboBox1.SelectedValue).ToList();
            comboBox2.DisplayMember = "DoktorAd";
            comboBox2.ValueMember = "DoktorID";
            comboBox2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rnd.BirimID =(int)comboBox1.SelectedValue;
                rnd.DoktorID=(int)comboBox2.SelectedValue;
                rnd.HastaID= (int)comboBox3.SelectedValue;
                rnd.RTarih =Convert.ToDateTime(dateTimePicker1.Text);
                rRepo.Insert(rnd);
                MessageBox.Show("Kayıt İşlemi Başarılı");
                getir();
                Temizle();
                dataGridView1.Visible = true;
                button2.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("İşlem Başarısız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int seciliid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                rRepo.Delete(seciliid);
                MessageBox.Show("Randevu İptal Edilmiştir");
                getir();
            }
            catch (Exception)
            {

                MessageBox.Show("İptal İşlemi Başarısız");
            }
           
        }
    }
}

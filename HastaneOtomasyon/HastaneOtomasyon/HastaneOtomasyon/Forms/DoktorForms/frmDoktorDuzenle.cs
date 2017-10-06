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
    
    public partial class frmDoktorDuzenle : Form
    {
        public frmDoktorDuzenle()
        {
            InitializeComponent();
        }

        DoktorRepository drRepo = new DoktorRepository();
        Doktor dr = new Doktor();
        private void cbBirimDoldur()
        {
            cbDduzBirim.DataSource = drRepo.SelectBirim().Select(x => new
            {
                x.BirimAd,
                x.BirimID
            }).ToList();
            cbDduzBirim.DisplayMember = "BirimAd";
            cbDduzBirim.ValueMember = "BirimID";
        }
        private void getir()
        {
            dataGridView1.DataSource = drRepo.SelectAll();
        }
        private void kilitAc()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            cbDduzBirim.Enabled = true;
        }
        private void frmDoktorDuzenle_Load(object sender, EventArgs e)
        {
            cbBirimDoldur();
            getir();
        }
        int secilenid;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                secilenid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                dr= drRepo.SelectByID(secilenid);
                textBox1.Text = dr.DoktorAd;
                textBox2.Text = dr.DoktorSoyad;
                textBox3.Text = dr.Maas.ToString();
                cbDduzBirim.SelectedValue = dr.BirimID;
                kilitAc();
            }
            catch (Exception)
            {

                MessageBox.Show("Doğru bir şekilde seçim yapamadınız");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dr.DoktorAd = textBox1.Text;
                dr.DoktorSoyad = textBox2.Text;
                dr.BirimID =(int)cbDduzBirim.SelectedValue;
                dr.Maas =Convert.ToInt32(textBox3.Text);
                drRepo.Update(dr);
                MessageBox.Show("Kayıt Güncellendi");
                getir();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme işlemi başarısız");
            }
           
        }

      
    }
}

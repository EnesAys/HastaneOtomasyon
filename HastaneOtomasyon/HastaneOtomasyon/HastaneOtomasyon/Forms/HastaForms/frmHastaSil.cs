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


namespace HastaneOtomasyon.Forms.HastaForms
{
    public partial class frmHastaSil : Form
    {
        public frmHastaSil()
        {
            InitializeComponent();
        }
        HastaRepository hRepo = new HastaRepository();
        private void getir()
        {
            dataGridView1.DataSource = hRepo.SelectAll();
        }
        private void frmHastaSil_Load(object sender, EventArgs e)
        {
            getir();
        }
        int seciliid;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                seciliid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                hRepo.Delete(seciliid);
                getir();
                MessageBox.Show("Kayıt Silindi");
            }
            catch (Exception)
            {

                MessageBox.Show("İşlem Gerçekleştirilemiyor");
            }
            
        }
    }
}

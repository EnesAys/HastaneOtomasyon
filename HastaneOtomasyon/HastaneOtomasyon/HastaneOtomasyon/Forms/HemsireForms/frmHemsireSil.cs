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


namespace HastaneOtomasyon.Forms.HemsireForms
{
    public partial class frmHemsireSil : Form
    {
        public frmHemsireSil()
        {
            InitializeComponent();
        }
        HemsireRepository hemRepo = new HemsireRepository();

        private void getir()
        {
            dataGridView1.DataSource = hemRepo.SelectAll();
        }
        
        private void frmHemsireSil_Load(object sender, EventArgs e)
        {
            getir();
        }
        int seciliid;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                seciliid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                hemRepo.Delete(seciliid);
                getir();
                MessageBox.Show("Kayıt Silindi");
            }
            catch (Exception)
            {

                MessageBox.Show("Silme işlemi Başarısız");
            }
           

        }
    }
}

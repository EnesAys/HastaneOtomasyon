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


namespace HastaneOtomasyon.Forms.DoktorForms
{
    public partial class frmDoktorSil : Form
    {
        public frmDoktorSil()
        {
            InitializeComponent();
        }
        DoktorRepository drRepo = new DoktorRepository();
        private void getir()
        {
            dataGridView1.DataSource = drRepo.SelectAll();
        }

        private void frmDoktorSil_Load(object sender, EventArgs e)
        {
            getir();
        }

        int secilenid;
        private void button1_Click(object sender, EventArgs e)
        {
            secilenid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            drRepo.Delete(secilenid);
            getir();
        }
    }
}


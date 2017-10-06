using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyon.Forms;
using HastaneOtomasyon.Forms.DoktorForms;
using HastaneOtomasyon.Forms.HastaForms;
using HastaneOtomasyon.Forms.HemsireForms;

namespace HastaneOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmDoktorEkle fdokEkle = new frmDoktorEkle();
        frmDoktorDuzenle fdokDuz = new frmDoktorDuzenle();
        frmDoktorSil fdokSil = new frmDoktorSil();
        frmHastaEkle fhasEkle = new frmHastaEkle();
        frmHastaDuzenle fhasDuz = new frmHastaDuzenle();
        frmHastaSil fhasSil = new frmHastaSil();
        frmHemsireEkle fhemEkle = new frmHemsireEkle();
        frmHemsireDuzenle fhemDuz = new frmHemsireDuzenle();
        frmHemsireSil fhemSil = new frmHemsireSil();
        frmRandevu fran = new frmRandevu();
       
        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdokEkle.ShowDialog();
               
        }

        private void doktorDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdokDuz.ShowDialog();
        }

        private void doktorSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdokSil.ShowDialog();
        }

        private void hemşireEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fhemEkle.ShowDialog();
        }

        private void hemşireDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fhemDuz.ShowDialog();
        }

        private void hemşireSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fhemSil.ShowDialog();
        }

        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fhasEkle.ShowDialog();
        }

        private void hastaDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fhasDuz.ShowDialog();
        }

        private void hastaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fhasSil.ShowDialog();
        }

        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fran.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityArchive
{
    public partial class SekreterSayfaForm : Form
    {
        public SekreterSayfaForm()
        {
            InitializeComponent();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

       

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void evrakEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvrakEklemeForm evrakEklemeForm = new EvrakEklemeForm();
            evrakEklemeForm.Show();
        }

        private void emanetVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetForm emanetForm = new EmanetForm();
            emanetForm.Show();
        }

        private void SekreterSayfaForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MemurSayfaForm : Form
    {
        public MemurSayfaForm()
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
            EvrakEklemeForm evraklarForm = new EvrakEklemeForm();
            evraklarForm.Show();
        }

        private void emanetAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetForm emanetForm = new EmanetForm();
            emanetForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

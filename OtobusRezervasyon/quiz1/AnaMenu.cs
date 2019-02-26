using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
        }

        private void ilEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityForm cityf = new CityForm();
            cityf.Show();
        }

        private void otobusEkleplakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBus formBus = new FormBus();
            formBus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormControl formControl = new FormControl();
            formControl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTakip formTakip = new FormTakip();
            formTakip.Show();
        }
    }
}

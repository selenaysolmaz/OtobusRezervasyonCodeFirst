using quiz1.Entities;
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
    public partial class FormBus : Form
    {
        public FormBus()
        {
            InitializeComponent();
        }
        BusModel db = new BusModel();
        int secilenID;
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                Bus bus = new Bus();
                bus.Name = txtotobusad.Text;
                bus.PlateNumber = txtplaka.Text;
                bus.SeatNumber = Convert.ToInt32(txtkoltuk.Text);
                db.Buses.Add(bus);
                db.SaveChanges();
                Listele();

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen tüm değerleri giriniz");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Listele()
        {
            var list = db.Buses.Select(x => new
            {
                BID = x.Id,
                BusName = x.Name
            }).ToList();
            dataGridView1.DataSource = list;
            txtplaka.Clear();
            txtotobusad.Clear();
            txtkoltuk.Clear();
            txtplaka.Focus();

        }

        private void FormBus_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            Bus b = db.Buses.Find(secilenID);
            db.Buses.Remove(b);
            db.SaveChanges();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Bus b = db.Buses.Find(secilenID);
                b.Name= txtotobusad.Text;
                b.PlateNumber = txtplaka.Text;
               
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen tüm değerleri giriniz");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Bus o = db.Buses.Find(secilenID);
            txtotobusad.Text = o.Name;
            txtplaka.Text = o.PlateNumber;
            txtkoltuk.Text = o.PlateNumber;
        }
    }
}

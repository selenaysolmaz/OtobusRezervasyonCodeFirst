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
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
        }
        BusModel db = new BusModel();
        int secilenID;

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            City c = db.Cities.Find(secilenID);
            db.Cities.Remove(c);
            db.SaveChanges();
            Listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                City i = db.Cities.Find(secilenID);
                i.Name = txtilAdi.Text;
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen tüm değerleri giriniz");
            }

        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                City city = new City();
                city.Name = txtilAdi.Text;
                db.Cities.Add(city);
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
            var list = db.Cities.Select(x => new
            {
                CID = x.Id,
                CityName = x.Name
            }).ToList();
            dataGridView1.DataSource = list;
            txtilAdi.Clear();
            txtilAdi.Focus();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            City il = db.Cities.Find(secilenID);
            txtilAdi.Text = il.Name;
        }
    }
}

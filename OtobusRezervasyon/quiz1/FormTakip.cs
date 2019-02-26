using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quiz1.Entities;

namespace quiz1
{
    public partial class FormTakip : Form
    {
        public FormTakip()
        {
            InitializeComponent();
        }
        BusModel db = new BusModel();
        int _secilenotobus;
        int _secilenTripID;
        private void ComboFillBus()
        {
            var list = db.Buses.OrderBy(x => x.PlateNumber).ToList();
            cbOtobus.DisplayMember = "PlateNumber";
            cbOtobus.ValueMember = "Id";
            cbOtobus.DataSource = list;
        }
        private void cbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _secilenotobus = (int)cbOtobus.SelectedValue;
            var PersonCount = (from x in db.Trips
                               where x.Bus.Id == _secilenotobus
                               select x).Count();
            txtKisiSayisi.Text = PersonCount.ToString();
            var sefer = db.Trips.Where(x=>x.Bus.Id ==_secilenotobus).ToList();
            cmbSefer.DisplayMember = "CityNames";
            cmbSefer.ValueMember = "Id";
            cmbSefer.DataSource = db.Trips.Where(t => t.Bus.Id == _secilenotobus).ToList();

        }

       

        private void FormTakip_Load(object sender, EventArgs e)
        {
            ComboFillBus();

        }

        private void btnAracHareketlendir_Click(object sender, EventArgs e)
        {
            if (txtKisiSayisi.Text != "" && txtKisiSayisi.Text != "0")
            {
                BusControlInfo controlInfo = new BusControlInfo
                {
                    PlateNumber = cbOtobus.Text,
                    TotalMoney = Convert.ToInt32(txtKisiSayisi.Text) * 100,
                    BeginTime = DateTime.Now
                };
                db.BusControlInfos.Add(controlInfo);
                db.SaveChanges();

                lstPlaka.Items.Add(cbOtobus.Text);
                lstTarih.Items.Add(DateTime.Now);
                int price = Convert.ToInt32(txtKisiSayisi.Text) * 100;
                lstHasilat.Items.Add(price.ToString());
                var trip = (Trip)cmbSefer.SelectedItem;
                db.TripPassengerInfo.RemoveRange(db.TripPassengerInfo.Where(x => x.trip.Id == trip.Id));
                db.Trips.Remove(trip);
                db.SaveChanges();
            }


        }

        private void btnGunlukArsiv_Click(object sender, EventArgs e)
        {
            lstGunlukKayitArsivi.Items.Clear();
            var ArchiveDate = (from x in db.BusControlInfos
                               where x.BeginTime.Day == DateTime.Now.Day
                               select x);
            foreach (var item in ArchiveDate)
            {
                lstGunlukKayitArsivi.Items.Add(item.PlateNumber + " - " + item.BeginTime + " - " + item.TotalMoney);
            }
        }

        private void btnAracDurumKaydet_Click(object sender, EventArgs e)
        {
           
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //masa ustu adresini alır.
            string yazdırlıcak = string.Empty;
            for (int i = 0; i < lstPlaka.Items.Count; i++)
            {
                yazdırlıcak += (lstPlaka.Items[i] + " - " + lstTarih.Items[i] + " - " + lstHasilat.Items[i]) + Environment.NewLine;
            }
            File.WriteAllText(path + @"\AracArsiv.txt", yazdırlıcak);
            lstTarih.Items.Clear();
            lstHasilat.Items.Clear();
            lstPlaka.Items.Clear();
            MessageBox.Show("Masaüstünde Ve Veritabanına Veriler Eklendi");
        }
    }
}

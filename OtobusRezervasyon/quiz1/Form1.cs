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
    public partial class Form1 : Form
    {
        private BusModel _busModel;
        List<Bus> alınan;
        BusModel db = new BusModel();
        private List<TripPassengerInfo> _tripPassengerInfos;
        private int _secilenSehirId;
        private Bus _secilenOtobus;
        private DateTime _secilenTarih;
        private Trip _secilenSefer;

        public Form1()
        {
            InitializeComponent();
            _busModel = new BusModel();
            _tripPassengerInfos = new List<TripPassengerInfo>();
            _secilenTarih = DateTime.Today;

            var trip = new Trip
            {
                Bus = _busModel.Buses.FirstOrDefault(),
                DepartureTime = DateTime.Now
            };
            FillBusList();
        }
        private void FillBusList()
        {
            lBBuses.Items.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CityAdd();
            PlakaAdd();
        }
        private void KoltukDoldur(int kapiSıraNo = 5)
        {
            flowLayoutPanel1.Controls.Clear();

            if (_secilenOtobus == null || _secilenTarih == null || _secilenSehirId < 1)
                return;

            _secilenSefer = db.Trips.FirstOrDefault(t => t.CityId == _secilenSehirId && t.DepartureTime == _secilenTarih && t.Bus.Id == _secilenOtobus.Id);

            //if (_secilenSefer == null)
            //    _secilenSefer = db.Trips.FirstOrDefault(t => t.CityId == _secilenSehirId && t.DepartureTime == _secilenTarih && t.Bus.Id == _secilenOtobus.Id);

            //for ile koltuk sayısı kadar koltuk oluşturulacak.
            for (int i = 1; i <= _secilenOtobus.SeatNumber; i++)
            {
                //koltukları button olarak tanımladık.
                Button koltuk = new Button();
                koltuk.Text = i.ToString();
                koltuk.Name = i.ToString();
                koltuk.ContextMenuStrip = contextMenuStrip1;
                koltuk.MouseDown += Koltuk_MouseDown;
                koltuk.Width = 40;
                koltuk.Height = 40;
                if (kapiSıraNo * 4 - 2 == i)
                    koltuk.Margin = new Padding(0, 0, 120, 0);
                else if (i % 4 == 3 && i < (kapiSıraNo - 1) * 4)
                    koltuk.Margin = new Padding(40, 0, 0, 0);
                else if (i % 4 == 1 && i > (kapiSıraNo) * 4)
                    koltuk.Margin = new Padding(40, 0, 0, 0);
                else
                    koltuk.Margin = new Padding(0);

                flowLayoutPanel1.Controls.Add(koltuk);
            }

            if (_secilenSefer == null)
                return;

            foreach (TripPassengerInfo tpi in _secilenSefer.TripPassengerInfo.ToList())
            {
                Control satinAlinanKoltuk = flowLayoutPanel1.Controls[tpi.KoltukNo];

                if (tpi.passenger.Gender == Gender.Female)
                    satinAlinanKoltuk.BackColor = Color.DeepPink;
                else
                    satinAlinanKoltuk.BackColor = Color.Blue;

                satinAlinanKoltuk.Enabled = false;
                satinAlinanKoltuk.ContextMenu = null;
            }
        }

        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = (Button)sender;
        }
        private void CityAdd()
        {
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = db.Cities.OrderBy(city => city.Id).ToList();
        }
        private void PlakaAdd()
        {
            alınan = db.Buses.OrderBy(x => x.Id).ToList();

            cmbPlaka.DisplayMember = "PlateNumber";
            cmbPlaka.ValueMember = "Id";
            cmbPlaka.DataSource = alınan;
        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(alınan.Where(a => a.PlateNumber.Equals(cmbPlaka.Text)).Select(sec => sec.SeatNumber).FirstOrDefault());
            kltkSayi.Value = x;

            _secilenOtobus = (Bus)cmbPlaka.SelectedItem;
            KoltukDoldur();
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FormBus bus = new FormBus();
            // List< Bus> bus1 = _busModel.Buses.Select(k=>k).ToList();
            int x = Convert.ToInt32(kltkSayi.Text);

            switch (toolStripComboBox1.SelectedItem.ToString())
            {

            }
        }
        private void bayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPassenger formPassenger = new FormPassenger();
            Passenger passenger = formPassenger.ShowFormDialog();

            if (passenger == null)
                return;

            Trip trip = db.Trips.FirstOrDefault(t => t.city.Id == _secilenSehirId && t.Bus.Id == _secilenOtobus.Id && t.DepartureTime == _secilenTarih);

            if (trip == null)
            {
                trip = new Trip()
                {
                    Bus = _secilenOtobus,
                    city = (City)comboBox1.SelectedItem,
                    DepartureTime = _secilenTarih
                };

                db.Trips.Add(trip);
            }

            _tripPassengerInfos.Add(new TripPassengerInfo()
            {
                passenger = passenger,
                KoltukNo = tiklanan.Text,
                trip = trip
            });

            tiklanan.BackColor = Color.Blue;
            _secilenSefer = trip;
        }
        private void bayanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPassenger formPassenger = new FormPassenger();
            Passenger passenger = formPassenger.ShowFormDialog();

            if (passenger == null)
                return;

            Trip trip = db.Trips.FirstOrDefault(t => t.city.Id == _secilenSehirId && t.Bus.Id == _secilenOtobus.Id && t.DepartureTime == _secilenTarih);

            if (trip == null)
            {
                trip = new Trip()
                {
                    Bus = _secilenOtobus,
                    city = (City)comboBox1.SelectedItem,
                    DepartureTime = _secilenTarih
                };

                db.Trips.Add(trip);
            }

            _tripPassengerInfos.Add(new TripPassengerInfo()
            {
                passenger = passenger,
                KoltukNo = tiklanan.Text,
                trip = trip
            });

            tiklanan.BackColor = Color.DeepPink;
            _secilenSefer = trip;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _secilenSehirId = (int)comboBox1.SelectedValue;
            KoltukDoldur();
        }

        private void dtpGun_ValueChanged(object sender, EventArgs e)
        {
            _secilenTarih = dtpGun.Value.Date;
            KoltukDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_secilenSefer == null)
                return;

            foreach (TripPassengerInfo tripPassengerInfo in _tripPassengerInfos)
            {
                _secilenSefer.TripPassengerInfo.Add(tripPassengerInfo);
            }

            db.SaveChanges();

            //FormPassenger formPassenger = new FormPassenger();
            //var trip = db.Trips.FirstOrDefault(x => x.CityId == (int)comboBox1.SelectedValue);
            //// var trippassenger = db.TripPassengerInfo.FirstOrDefault(x => x.TripId == (int)Trip.Id);
            //if (trip == null)
            //{
            //    trip = new Trip();
            //    trip.DepartureTime = dtpGun.Value;
            //    trip.city = db.Cities.Find(comboBox1.SelectedValue);
            //    trip.Bus = db.Buses.Find(cmbPlaka.SelectedValue);
            //    db.Trips.Add(trip);
            //    db.SaveChanges();
            //}
            //FormPassenger fp = new FormPassenger();
            //TripPassengerInfo trppasengerinfo = new TripPassengerInfo();
            //trppasengerinfo.trip = trip;
            //// trppasengerinfo.PassengerId =db.Passengers.FirstOrDefault(x => x.IdentificationNumber == fp.txtTc.Text).Id;

            ////ıd = db.Passengers.FirstOrDefault(x => x.IdentificationNumber == txtTc.Text).Id;
            ////trppasengerinfo.passenger = db.Passengers.Find(fp.ıd);
            //trppasengerinfo.KoltukNo = tiklanan.Text;
            ////trppasengerinfo.PassengerId=2;
            //db.TripPassengerInfo.Add(trppasengerinfo);
            //db.SaveChanges();


        }
    }
}

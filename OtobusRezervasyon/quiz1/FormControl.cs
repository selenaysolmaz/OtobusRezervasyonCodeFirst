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
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }
        BusModel db = new BusModel();
        private void FormControl_Load(object sender, EventArgs e)
        {
            BİletKontrol();
        }
        private void BİletKontrol()
        {
            foreach (var item in db.TripPassengerInfo)
            {

                lBNameSurname.Items.Add(item.passenger.FirstName + item.passenger.LastName);
                lBPlateNumber.Items.Add(item.trip.Bus.PlateNumber);
                lBSeatNumber.Items.Add(item.KoltukNo);
                lBTrip.Items.Add(item.trip.city.Name);
                tstTel.Items.Add(item.passenger.PhoneNumber);
            }
        }
    }
}

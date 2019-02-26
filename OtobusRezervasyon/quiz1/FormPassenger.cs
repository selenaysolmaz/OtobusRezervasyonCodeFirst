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
    public partial class FormPassenger : Form
    {
        private Form1 _form;
        private Passenger _passenger;

        public FormPassenger()
        {
            InitializeComponent();
            
        }
        BusModel db = new BusModel();
        public int ıd;
        private void FormPassenger_Load(object sender, EventArgs e)
        {
            
        }

        public Passenger ShowFormDialog()
        {
            ShowDialog();
            return _passenger;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            try
            {
                Passenger passenger = new Passenger();
                passenger.FirstName = txtFirstName.Text;
                passenger.LastName = txtLastName.Text;
                passenger.PhoneNumber = txtPhoneNum.Text;
                passenger.IdentificationNumber = txtTc.Text;
                passenger.Birthdate = dateTimePicker1.Value;
                if (rbBayan.Checked)
                {
                    passenger.Gender = Gender.Female;
                }
                else if (rbBay.Checked)
                {
                    passenger.Gender = Gender.Male;
                }

                //_passenger = passenger;
                db.Passengers.Add(passenger);
                db.SaveChanges();
                //_passenger = db.Passengers.FirstOrDefault(x => x.IdentificationNumber == passenger.IdentificationNumber);
                _passenger = passenger;

            }

            catch (Exception)
            {

                MessageBox.Show("Lütfen tüm değerleri giriniz");
            }

        
            this.DialogResult = DialogResult.OK;
            this.Close();
            //while (txtFirstName.Text == "" || txtLastName.Text == "" || txtLastName.Text == "" || txtPhoneNum.Text == "" || txtTc.Text == "")
            //{
            //    MessageBox.Show("boş alan bırakmayınız");
            //}


        }

        private void rbBayan_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbBay_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}

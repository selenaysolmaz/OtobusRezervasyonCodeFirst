using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace quiz1.Entities
{
    ////bu alanda Passenger diye tablo olusturup tablo sütünlarını asagıdaki özellikleri alıyor.
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime Birthdate { get; set; }


    }
}

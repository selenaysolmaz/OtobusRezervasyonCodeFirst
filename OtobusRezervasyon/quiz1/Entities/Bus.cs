using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1.Entities
{
    //bu alanda Bus diye tablo olusturup tablo sütünlarını asagıdaki özellikleri alıyor.
    public class Bus
    {
        public int Id { get; set; }
        [Required]//boş geçilmemesi için
        public string PlateNumber { get; set; }
        public string Name { get; set; }
        public int SeatNumber { get; set; }
        //public int? DriverId { get; set; }
        //struct sonuna ? koyarsan boş girilebilir.

        public override string ToString()
        {
            return Name + " " + PlateNumber;
        }
    }
    
}

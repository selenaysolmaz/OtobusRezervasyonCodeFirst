using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1.Entities
{  ////bu alanda Trip diye tablo olusturup tablo sütünlarını asagıdaki özellikleri alıyor.
    public class Trip
    {
        public int Id { get; set; }
        public virtual Bus Bus { get; set; }  //fk oldu
        public DateTime DepartureTime { get; set; }
        public int CityId { get; set; }

        public virtual City city { get; set; }
        public virtual ICollection<TripPassengerInfo> TripPassengerInfo { get; set; }

        public Trip()
        {
            this.TripPassengerInfo = new HashSet<TripPassengerInfo>();

        }
        public override string ToString()
        {
            return city.Name;
        }
        public string CityNames { get { return this.ToString(); } }

    }
}

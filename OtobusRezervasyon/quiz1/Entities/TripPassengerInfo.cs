using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1.Entities
{
   public class TripPassengerInfo
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public int PassengerId { get; set; }
        public string KoltukNo { get; set; }

        public virtual Passenger passenger { get; set; }
        public virtual Trip trip { get; set; }

    }
}

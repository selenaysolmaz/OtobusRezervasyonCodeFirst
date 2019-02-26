using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1.Entities
{
    public class BusControlInfo
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public DateTime BeginTime { get; set; }
        public int TotalMoney { get; set; }
    }
}

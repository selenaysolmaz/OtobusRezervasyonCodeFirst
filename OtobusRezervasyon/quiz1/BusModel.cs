using quiz1.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace quiz1
{


    public class BusModel : DbContext
    {
        
        public BusModel()
            : base("name=BusModel")
        {


        }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripPassengerInfo> TripPassengerInfo { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<BusControlInfo> BusControlInfos { get; set; }
    }





}
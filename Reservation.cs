using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Windows;

namespace BrahimsAirline
{
    class Reservation
    {
        public Flight flight;
        public Package package;

        public int id;
        public DateTime flightDate, deliveryTime, flightTime, confirmedTime;
        public bool isComplete;

        public Reservation(Flight flight, Package package)
        {
            this.flight = flight;
            this.package = package;
            this.isComplete = false;
        }

        public Reservation()
        {

        }

        public bool make(DateTime flightDate, DateTime deliveryTime, DateTime flightTime)
        {
            this.flightDate = flightDate;
            this.deliveryTime = deliveryTime;
            this.flightTime = flightTime;

            return true;
        }

        public double totalCost()
        {
            return (this.flight.businessPassenger * this.package.businessPrice) 
                + (this.flight.economyPassenger * this.package.economyPrice);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BrahimsAirline
{
    class MakeReservation
    {
        ArrayList reservationCollection = new ArrayList();

        public Reservation makeReservation(Flight flight, Package package)
        {
            Console.WriteLine("\n====== Reservation Details ======\n");

            Reservation reservation = new Reservation(flight, package);
        }

        public void addReservationToCollection(Reservation reservation)
        {
            this.reservationCollection.Add(reservation);
        }
    }
}
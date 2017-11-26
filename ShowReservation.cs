using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BrahimsAirline
{
    class Operation
    {
        string choice;
        int incremental = 0;

        ArrayList reservationCollection = new ArrayList();

        public void showReservationDetails(Reservation reservation)
        {
            Console.WriteLine("Reservation ID \t\t\t\t: " + reservation.id + "\n");
            Console.WriteLine("Airline Name \t\t\t\t: " + reservation.flight.airlineName + "\n");
            Console.WriteLine("Flight Registration Number \t\t: " + reservation.flight.registrationNumber + "\n");
            Console.WriteLine("Quantity of Economy Passenger \t\t: " + reservation.flight.economyPassenger + "\n");
            Console.WriteLine("Quantity of Business Passenger \t\t: " + reservation.flight.businessPassenger + "\n");

            Console.WriteLine("Package Type \t\t\t\t: " + reservation.package.packageType + "\n");
            Console.WriteLine("Economy Price \t\t\t\t: RM " + reservation.package.economyPrice + "\n");
            Console.WriteLine("Business Price \t\t\t\t: RM " + reservation.package.businessPrice + "\n");

            Console.WriteLine("Flight Date \t\t\t\t: " + reservation.flightDate.ToString("d") + "\n");
            Console.WriteLine("Delivery Time \t\t\t\t: " + reservation.deliveryTime.ToString("hh:mm tt") + "\n");
            Console.WriteLine("Flight Time \t\t\t\t: " + reservation.flightTime.ToString("hh:mm tt") + "\n");
            Console.WriteLine("Delivered Status \t\t\t: " + reservation.isComplete + "\n");
            if(reservation.isComplete == true)
            {
                Console.WriteLine("Confirmed Delivery Time \t\t: " + reservation.confirmedTime.ToString("hh:mm tt") + "\n");
            }
            Console.WriteLine("Total Cost \t\t\t\t: RM " + reservation.totalCost() + "\n");
            Console.WriteLine("\n\n");
        }

        public void showAllReservation()
        {
            Console.Clear();

            if(reservationCollection.Count == 0)
            {
                Console.WriteLine("No reservation recorded. \n");
            }

            Reservation reservation = new Reservation();

            foreach (object data in reservationCollection)
            {
                reservation = (Reservation)data;

                showReservationDetails(reservation);
            }
        }
    }
}
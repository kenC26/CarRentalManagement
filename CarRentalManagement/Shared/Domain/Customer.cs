using System;
using System.Collections.Generic;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string LicensePlateNUmber { get; set; }
        public string Address { get; set; }

        public string Contact { get; set; }
        public string EmailAdresss { get; set; }

        public virtual List<Booking> Bookings { get; set; }
    }
}
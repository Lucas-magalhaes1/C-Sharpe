using Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    internal class RentalSevice
    {
        public Double PricePerHour { get; private set; }
        public Double PricePerDay { get; private set; }

        private BrazilTaxService _taxService;

        public RentalSevice(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = (BrazilTaxService)taxService;
        }

        public void ProcessInvoice(CarRental carRetal)
        {
            TimeSpan duration = carRetal.Finish.Subtract(carRetal.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }else
            {
                basicPayment = PricePerDay * Math.Ceiling (duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRetal.Invoice = new Invoice(basicPayment, tax);
        }
    }
}

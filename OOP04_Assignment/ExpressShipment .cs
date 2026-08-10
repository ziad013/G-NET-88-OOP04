using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04_Assignment
{
    internal class ExpressShipment : Shipment
    {
        
        private decimal extraFee;

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + ExtraFee;



        public ExpressShipment(string trackingCode, string description, double weight,
            decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight,
               deliveryFee, destination)
        {
            ExtraFee = extraFee;
            Name = "Express Shipment";
        }

        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Express Shipment---------------");
            Console.WriteLine();
            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee} EGP");
        }
    }
}

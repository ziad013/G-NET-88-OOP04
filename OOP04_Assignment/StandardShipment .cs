using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04_Assignment
{

    internal class StandardShipment : Shipment
    {

        public StandardShipment(string trackingCode, string description, double weight,
             decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight,
                deliveryFee, destination)
        {
            Name = "Standard Shipment";
        }

        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------Standard Shipment----------------");
            Console.WriteLine();
            base.PrintShipment();
        }

    }
}

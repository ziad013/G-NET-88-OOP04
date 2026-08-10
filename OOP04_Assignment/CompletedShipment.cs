using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04_Assignment
{
    internal sealed class CompletedShipment:Shipment
    {
        public CompletedShipment(
       string trackingCode,
       string description,
       double weight,
       decimal deliveryFee,
       DeliveryAddress destination)
       : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }
    }
}

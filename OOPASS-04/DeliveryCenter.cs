////Q7

using System;
using System.Collections.Generic;

public class DeliveryCenter
{
    private List<Shipment> shipments = new List<Shipment>();

    public void AddShipment(Shipment shipment)
    {
        shipments.Add(shipment);
    }

    public void PrintTrackingStatuses()
    {
        foreach (ITrackable shipment in shipments)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
    }
}


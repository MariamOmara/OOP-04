//Q1 PRAC

//public abstract class Shipment
//{
//    public string TrackingCode { get; set; }
//    public string Description { get; set; }
//    public decimal Weight { get; set; }
//    public decimal DeliveryFee { get; set; }
//    public DeliveryAddress Destination { get; set; }
//}



//Q2 PRACT
//public abstract class Shipment
//{
//    public string TrackingCode { get; set; }
//    public string Description { get; set; }
//    public decimal Weight { get; set; }
//    public decimal DeliveryFee { get; set; }
//    public DeliveryAddress Destination { get; set; }

//    public abstract decimal EstimatedCost { get; }

//    public abstract void PrintShipment();
//}




//Q3 PRACT 

//public abstract class Shipment
//{
//    public string TrackingCode { get; set; }
//    public string Description { get; set; }
//    public decimal Weight { get; set; }
//    public decimal DeliveryFee { get; set; }
//    public DeliveryAddress Destination { get; set; }

//    public Shipment(
//        string trackingCode,
//        string description,
//        decimal weight,
//        decimal deliveryFee,
//        DeliveryAddress destination)
//    {
//        TrackingCode = trackingCode;
//        Description = description;
//        Weight = weight;
//        DeliveryFee = deliveryFee;
//        Destination = destination;
//    }

//    public abstract decimal EstimatedCost { get; }

//    public abstract void PrintShipment();
//}



//Q5 PRACT

//public abstract class Shipment
//{
//    public string TrackingCode { get; set; }
//    public string Description { get; set; }
//    public decimal Weight { get; set; }
//    public decimal DeliveryFee { get; set; }
//    public DeliveryAddress Destination { get; set; }

//    public Shipment(
//        string trackingCode,
//        string description,
//        decimal weight,
//        decimal deliveryFee,
//        DeliveryAddress destination)
//    {
//        TrackingCode = trackingCode;
//        Description = description;
//        Weight = weight;
//        DeliveryFee = deliveryFee;
//        Destination = destination;
//    }

//    public abstract decimal EstimatedCost { get; }

//    public abstract void PrintShipment();
//}


//public class StandardShipment : Shipment, IInsurable
//{
//    public StandardShipment(
//        string trackingCode,
//        string description,
//        decimal weight,
//        decimal deliveryFee,
//        DeliveryAddress destination)
//        : base(trackingCode, description, weight, deliveryFee, destination)
//    {
//    }

//    public override decimal EstimatedCost
//    {
//        get
//        {
//            return DeliveryFee + (Weight * 5);
//        }
//    }

//    public override void PrintShipment()
//    {
//        Console.WriteLine("Standard Shipment");
//        Console.WriteLine($"Tracking Code : {TrackingCode}");
//        Console.WriteLine($"Description   : {Description}");
//        Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
//        Console.WriteLine("------------------------------------------");
//    }

//    public decimal CalculateInsurance()
//    {
//        return EstimatedCost * 0.05m;
//    }
//}


//public class ExpressShipment : Shipment, IInsurable
//{
//    public decimal ExtraFee { get; set; }

//    public ExpressShipment(
//        string trackingCode,
//        string description,
//        decimal weight,
//        decimal deliveryFee,
//        decimal extraFee,
//        DeliveryAddress destination)
//        : base(trackingCode, description, weight, deliveryFee, destination)
//    {
//        ExtraFee = extraFee;
//    }

//    public override decimal EstimatedCost
//    {
//        get
//        {
//            return DeliveryFee + (Weight * 5) + ExtraFee;
//        }
//    }

//    public override void PrintShipment()
//    {
//        Console.WriteLine("Express Shipment");
//        Console.WriteLine($"Tracking Code : {TrackingCode}");
//        Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
//        Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
//        Console.WriteLine("------------------------------------------");
//    }

//    public decimal CalculateInsurance()
//    {
//        return EstimatedCost * 0.08m;
//    }
//}


//public class InternationalShipment : Shipment, IInsurable
//{
//    public string DestinationCountry { get; set; }

//    public InternationalShipment(
//        string trackingCode,
//        string description,
//        decimal weight,
//        decimal deliveryFee,
//        string destinationCountry,
//        DeliveryAddress destination)
//        : base(trackingCode, description, weight, deliveryFee, destination)
//    {
//        DestinationCountry = destinationCountry;
//    }

//    public override decimal EstimatedCost
//    {
//        get
//        {
//            return DeliveryFee + (Weight * 10);
//        }
//    }

//    public override void PrintShipment()
//    {
//        Console.WriteLine("International Shipment");
//        Console.WriteLine($"Tracking Code      : {TrackingCode}");
//        Console.WriteLine($"Destination Country: {DestinationCountry}");
//        Console.WriteLine($"Estimated Cost     : {EstimatedCost} EGP");
//        Console.WriteLine("------------------------------------------");
//    }

//    public decimal CalculateInsurance()
//    {
//        return EstimatedCost * 0.12m;
//    }
//}





//Q7 PR

//public abstract class Shipment
//{
//    public string TrackingCode { get; set; }
//    public string Description { get; set; }
//    public decimal Weight { get; set; }
//    public decimal DeliveryFee { get; set; }
//    public DeliveryAddress Destination { get; set; }

//    public Shipment(
//        string trackingCode,
//        string description,
//        decimal weight,
//        decimal deliveryFee,
//        DeliveryAddress destination)
//    {
//        TrackingCode = trackingCode;
//        Description = description;
//        Weight = weight;
//        DeliveryFee = deliveryFee;
//        Destination = destination;
//    }

//    public abstract decimal EstimatedCost { get; }

//    public abstract void PrintShipment();
//}
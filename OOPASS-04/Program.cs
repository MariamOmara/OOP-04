
//Q8 PRAC

//class Program
//{
//    static void Main(string[] args)
//    {
//        DeliveryAddress address1 =
//            new DeliveryAddress("Cairo", "Nasr City", 10);

//        DeliveryAddress address2 =
//            new DeliveryAddress("Giza", "Dokki", 20);

//        DeliveryAddress address3 =
//            new DeliveryAddress("Berlin", "Main Street", 30);


//        StandardShipment standardShipment =
//            new StandardShipment(
//                "SH001",
//                "Laptop",
//                10,
//                45,
//                address1);


//        ExpressShipment expressShipment =
//            new ExpressShipment(
//                "SH002",
//                "Phone",
//                10,
//                20,
//                30,
//                address2);


//        InternationalShipment internationalShipment =
//            new InternationalShipment(
//                "SH003",
//                "Package",
//                20,
//                60,
//                "Germany",
//                address3);


//        DeliveryCenter deliveryCenter = new DeliveryCenter();

//        deliveryCenter.AddShipment(standardShipment);
//        deliveryCenter.AddShipment(expressShipment);
//        deliveryCenter.AddShipment(internationalShipment);


//        Console.WriteLine("==========================================");
//        Console.WriteLine("Delivery Center");
//        Console.WriteLine("==========================================");
//        Console.WriteLine();


//        // Print all shipment details
//        standardShipment.PrintShipment();
//        expressShipment.PrintShipment();
//        internationalShipment.PrintShipment();


//        // Print tracking status
//        Console.WriteLine("Tracking Status");
//        Console.WriteLine("==========================================");

//        deliveryCenter.PrintTrackingStatuses();

//        Console.WriteLine();


//        // Print insurance
//        Console.WriteLine("Insurance");
//        Console.WriteLine("==========================================");

//        DeliveryReport report = new DeliveryReport();

//        report.PrintInsurance(standardShipment);
//        report.PrintInsurance(expressShipment);
//        report.PrintInsurance(internationalShipment);

//        Console.WriteLine();


//        // ITrackable array
//        ITrackable[] trackableShipments =
//        {
//            standardShipment,
//            expressShipment,
//            internationalShipment
//        };

//        Console.WriteLine("ITrackable Array");
//        Console.WriteLine("==========================================");

//        foreach (ITrackable shipment in trackableShipments)
//        {
//            Console.WriteLine(shipment.GetTrackingStatus());
//        }

//        Console.WriteLine();


//        // IInsurable array
//        IInsurable[] insurableShipments =
//        {
//            standardShipment,
//            expressShipment,
//            internationalShipment
//        };

//        Console.WriteLine("IInsurable Array");
//        Console.WriteLine("==========================================");

//        foreach (IInsurable shipment in insurableShipments)
//        {
//            Console.WriteLine($"Insurance: {shipment.CalculateInsurance()} EGP");
//        }

//        Console.WriteLine();
//        Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
//    }
//}


//النظريQ1

//a/ What is Abstraction in Object-Oriented Programming?

//Abstraction is the process of hiding unnecessary implementation details and showing only the essential features of an object.

//B
//Why is abstraction considered one of the four pillars of OOP?

//Abstraction is one of the four pillars of OOP because it reduces complexity by hiding unnecessary details and exposing only the essential functionality.



//Q2 النظري

//A
//Abstract Class = Base class فيها implementation + abstract members.
//Interface = Contract يحدد what the class must do.

//B
//We choose an Interface when different classes need to share the same behavior or contract, even if they do not have the same base class.

//C
//A class cannot inherit from multiple classes, including abstract classes.However, a class can implement multiple interfaces.

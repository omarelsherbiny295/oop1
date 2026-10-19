namespace oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryCenter center = new DeliveryCenter();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Shipment " + (i + 1) + " Data");

                Console.Write("Tracking Code: ");
                string code = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal fee = Convert.ToDecimal(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int building = Convert.ToInt32(Console.ReadLine());

                DeliveryAddress address =
                    new DeliveryAddress(city, street, building);

                Shipment shipment =
                    new Shipment(code, description, weight, fee, address);

                if (center.AddShipment(shipment))
                {
                    Console.WriteLine("Shipment added successfully.");
                }
                else
                {
                    Console.WriteLine("Delivery Center is full.");
                }

                Console.WriteLine();
            }

            Console.WriteLine("All Shipments");

            for (int i = 0; i < 3; i++)
            {
                center[i].PrintShipment();
                Console.WriteLine("------------------");
            }

            Console.Write("Enter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();

            Shipment result = center[searchCode];

            if (result.TrackingCode == searchCode)
            {
                result.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Console.WriteLine();
            Console.WriteLine("Delivery Address Copy Test");

            DeliveryAddress address1 =
                new DeliveryAddress("Cairo", "Tahrir Street", 15);

            DeliveryAddress address2 = address1;

            address2.City = "Alexandria";

            Console.WriteLine("Original: " + address1.GetFullAddress());
            Console.WriteLine("Copy: " + address2.GetFullAddress());

            Console.ReadLine();
        }
    }
}


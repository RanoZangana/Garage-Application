using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace GarageApplication
{
    public interface IEnumerable<T>
    {
        public void ListVehicle();
    }
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private List<T> parkedVehicles;
        public Garage(int maxVehicleCapacity)
        {
            parkedVehicles = new List<T>(maxVehicleCapacity);
        }
        public Bicycle MakeBicycle()
        {
            Console.WriteLine("Manufacturer: ");
            string vehicleManufacturer = Console.ReadLine();
            Console.WriteLine("Registration Number: ");
            string vehicleRegNr = Console.ReadLine();
            Console.WriteLine("Color: ");
            string vehicleColor = Console.ReadLine();
            Console.WriteLine("Amount of Wheels: ");
            int vehicleWheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Amount of Gears: ");
            int vehicleGears = int.Parse(Console.ReadLine());
            Console.WriteLine("Is it a BMX (Yes/No): ");
            string vehicleBMX = Console.ReadLine();
            bool vehicleIsBMX;
            if (vehicleBMX == "Yes")
            {
                vehicleIsBMX = true;
            }
            else
            {
                vehicleIsBMX = false;
            }

            Bicycle item = new Bicycle(vehicleManufacturer, vehicleRegNr, vehicleColor, vehicleWheels,
                    vehicleGears, vehicleIsBMX);
            return item;
        }
        public Bus MakeBus()
        {
            Console.WriteLine("Manufacturer: ");
            string vehicleManufacturer = Console.ReadLine();
            Console.WriteLine("Registration Number: ");
            string vehicleRegNr = Console.ReadLine();
            Console.WriteLine("Color: ");
            string vehicleColor = Console.ReadLine();
            Console.WriteLine("Amount of Wheels: ");
            int vehicleWheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximum Passanger Capacity: ");
            int vehicleMaxPasCap = int.Parse(Console.ReadLine());
            Console.WriteLine("Is it a School Bus? (Yes/No): ");
            string vehicleSchool = Console.ReadLine();
            bool vehicleIsSchool;
            if (vehicleBMX == "Yes")
            {
                vehicleIsSchool = true;
            }
            else
            {
                vehicleIsSchool = false;
            }

            Bus item = new Bus(vehicleManufacturer, vehicleRegNr, vehicleColor, vehicleWheels,
                    vehicleIsSchool, vehicleMaxPasCap);
            return item;
        }
        public Car MakeCar()
        {
            Console.WriteLine("Manufacturer: ");
            string vehicleManufacturer = Console.ReadLine();
            Console.WriteLine("Registration Number: ");
            string vehicleRegNr = Console.ReadLine();
            Console.WriteLine("Color: ");
            string vehicleColor = Console.ReadLine();
            Console.WriteLine("Amount of Wheels: ");
            int vehicleWheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Amount of Horsepower: ");
            int vehicleHP = int.Parse(Console.ReadLine());
            Console.WriteLine("Is it a Convertable (Yes/No): ");
            string vehicleConv = Console.ReadLine();
            bool vehicleIsConv;
            if (vehicleBMX == "Yes")
            {
                vehicleIsConv = true;
            }
            else
            {
                vehicleIsConv = false;
            }

            Car item = new Car(vehicleManufacturer, vehicleRegNr, vehicleColor, vehicleWheels,
                    vehicleHP, vehicleIsConv);
            return item;
        }
        public Truck MakeTruck()
        {
            Console.WriteLine("Manufacturer: ");
            string vehicleManufacturer = Console.ReadLine();
            Console.WriteLine("Registration Number: ");
            string vehicleRegNr = Console.ReadLine();
            Console.WriteLine("Color: ");
            string vehicleColor = Console.ReadLine();
            Console.WriteLine("Amount of Wheels: ");
            int vehicleWheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Is it an All Wheel Drive? (Yes/No): ");
            string vehicleAllWheelDrive = Console.ReadLine();
            bool vehicleIsAllWheelDrive;
            if (vehicleAllWheelDrive == "Yes")
            {
                vehicleIsAllWheelDrive = true;
            }
            else
            {
                vehicleIsAllWheelDrive = false;
            }
            Console.WriteLine("Does it run on Diesel? (Yes/No): ");
            string vehicleDiesel = Console.ReadLine();
            bool vehicleIsDiesel;
            if (vehicleDiesel == "Yes")
            {
                vehicleIsDiesel = true;
            }
            else
            {
                vehicleIsDiesel = false;
            }

            Truck item = new Truck(vehicleManufacturer, vehicleRegNr, vehicleColor, vehicleWheels,
                    vehicleIsAllWheelDrive, vehicleIsDiesel);
            return item;
        }
        public Motorcycle MakeMotorcycle()
        {
            Console.WriteLine("Manufacturer: ");
            string vehicleManufacturer = Console.ReadLine();
            Console.WriteLine("Registration Number: ");
            string vehicleRegNr = Console.ReadLine();
            Console.WriteLine("Color: ");
            string vehicleColor = Console.ReadLine();
            Console.WriteLine("Amount of Wheels: ");
            int vehicleWheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Cubic Capacity: ");
            int vehicleGears = int.Parse(Console.ReadLine());
            Console.WriteLine("Does it have Ape Hangers (Yes/No): ");
            string vehicleApe = Console.ReadLine();
            bool vehicleIsApe;
            if (vehicleApe == "Yes")
            {
                vehicleIsApe = true;
            }
            else
            {
                vehicleIsApe = false;
            }

            Motorcycle item = new Motorcycle(vehicleManufacturer, vehicleRegNr, vehicleColor, vehicleWheels,
                    vehicleGears, vehicleIsApe);
            return item;
        }

        public void AddVehicle(T item)
        {
            parkedVehicles.Add(item);
        }
        public void ListVehicle()
        {
            foreach (T item in parkedVehicles)
            {
                Console.WriteLine($"{ item.GetType().Name }, { item.RegistrationNumber }");
                Console.WriteLine(item);
            }
        }
        public void CountVehicleTypes()
        {
            int bicycleCount = 0, busCount = 0, carCount = 0, motorcycleCount = 0, truckCount = 0;
            foreach (var item in parkedVehicles)
            {
                if (item.GetType().Name == "Bicycle")
                {
                    bicycleCount++;
                }
                else if (item.GetType().Name == "Bus")
                {
                    busCount++;
                }
                else if (item.GetType().Name == "Car")
                {
                    carCount++;
                }
                else if (item.GetType().Name == "Motorcycle")
                {
                    motorcycleCount++;
                }
                else if (item.GetType().Name == "Truck")
                {
                    truckCount++;
                }
            }
            Console.WriteLine($"Amount of bicycles in garage: { bicycleCount }\n" +
                $"Amount of buses in garage: { busCount }\n" +
                $"Amount of cars in garage: { carCount }\n" +
                $"Amount of motorcycles in garage: { motorcycleCount }\n" +
                $"Amount of trucks in garage: { truckCount }\n" +
                $"Total amount of vehicles in garage: { bicycleCount + busCount + carCount + motorcycleCount + truckCount}");            
        }
        /// <summary>
        /// SearchVehicle finds first object with a property that matches the search phrase and returns it.
        /// </summary>
        public void SearchVehicle(string searchString)
        {
            string[] keywords = searchString.Split(' ');
            foreach (var key in keywords)
            {
                foreach (T item in parkedVehicles)
                {
                    if (item.RegistrationNumber.ToUpper() == key.ToUpper())
                    {
                        Console.WriteLine($"Vehicle found!\n { item }\n");
                    }
                    else if (item.Color.ToUpper() == key.ToUpper())
                    {
                        Console.WriteLine($"Vehicle found!\n { item }\n");
                    }
                    else if (item.GetType().Name.ToUpper() == key.ToUpper())
                    {
                        Console.WriteLine($"Vehicle found!\n { item }\n");
                    }
                    else if (Convert.ToString(item.WheelsAmount) == key)
                    {
                        Console.WriteLine($"Vehicle found!\n { item }\n");
                    }
                    else if (Convert.ToString(item.Manufacturer) == key)
                    {
                        Console.WriteLine($"Vehicle found!\n { item }\n");
                    }
                }
            }
        }
        public void RemoveVehicle(T item)
        {
            parkedVehicles.Remove(item);
            Console.WriteLine($"{ item.GetType().Name } with reg nr { item.RegistrationNumber } removed!\n");
        }
    }
}

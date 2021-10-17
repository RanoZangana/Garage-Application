using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApplication
{
    public class Menu
    {


        public Menu()
        {
       
            StartMenu();
        }
        public void StartMenu()
        {
            Garage<Vehicle> newGarage = new Garage<Vehicle>(20);
            bool quitApplication = false;
            Console.WriteLine(
                "1. Search Vehicle\n" +
                "2. Add Vehicle\n" +
                "3. Remove Vehicle\n" +
                "4. List Vehicles\n" +
                "5. Amount of Vehicles\n" +
                "6. Exit the Garage");
            do
            {
                string parseChoice = Console.ReadLine();
                int.TryParse(parseChoice, out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Search for a vehicle in the garage.");
                        newGarage.SearchVehicle(Console.ReadLine());
                        continue;
                    case 2:
                        Console.WriteLine("What type of vehicle would you like to add?\n");
                        string addedType = Console.ReadLine();
                        if (addedType == "Bicycle")
                        {
                            Bicycle bike = newGarage.MakeBicycle();
                            newGarage.AddVehicle(bike);
                        }
                        else if (addedType == "Bus")
                        {
                            Bus bus = newGarage.MakeBus();
                            newGarage.AddVehicle(bus);
                        }
                        else if (addedType == "Car")
                        {
                            Car car = newGarage.MakeCar();
                            newGarage.AddVehicle(car);
                        }
                        else if (addedType == "Motorcycle")
                        {
                            Motorcycle motorbike = newGarage.MakeMotorcycle();
                            newGarage.AddVehicle(motorbike);
                        }
                        else if (addedType == "Truck")
                        {
                            Truck truck = newGarage.MakeTruck();
                            newGarage.AddVehicle(truck);
                        }
                        continue;
                    case 3:
                        Console.WriteLine($"Current pet shop funds: { animalShop.ShopMoney }\n");
                        continue;
                    case 4:
                        if (purchasedAnimals.Count != 0)
                        {
                            Console.WriteLine("Purchased animals: \n");
                            foreach (var animal in purchasedAnimals)
                            {
                                Console.WriteLine(animal);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have not purchased any animals!");
                        }
                        continue;
                    case 5:
                        Console.WriteLine("Exiting the pet shop ...");
                        stopLoop = true;
                        break;
                    default:
                        Console.WriteLine("Only accepts 1-4 as input!");
                        continue;
                } while (!quitApplication) ;
            }
    }
    }
}

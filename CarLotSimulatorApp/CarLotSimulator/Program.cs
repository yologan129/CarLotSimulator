using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            //Set the properties for each of the cars
            //Call each of the methods for each car

            //dot notation
            var logansCar = new Car();
            logansCar.Make = "Ford";
            logansCar.Model = "Focus";
            logansCar.Year = 2014;
            logansCar.EngineNoise = "vroom";
            logansCar.HonkNoise = "beep";
            logansCar.IsDrivable = true;

            //Object intializer syntax
            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "breep",
                IsDrivable = false
            };

            //using a constructor
            var sethCar = new Car(2019, "Tesla", "Cyber Truck", "...", "breep", false);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var parkingLot = new CarLot();
            parkingLot.ParkingLot = new List<Car>() {sethCar, logansCar, stevesCar};
            foreach (var car in parkingLot.ParkingLot)
            {
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}");
            }
                
        }
    }
}

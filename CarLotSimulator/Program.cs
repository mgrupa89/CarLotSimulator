using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car DONE


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Carlot lot = new Carlot();

            //Using Dot Notation
            Car fiat = new Car();
            lot.CarList.Add(fiat);
            fiat.CarMake = "Fiat";
            fiat.CarModel = "500 Abarth";
            fiat.CarYear = 2015;
            fiat.EngineNoise = "Vroom";
            fiat.Horn = "beep";
            fiat.IsDrivable = true;

            //Object Initializer Syntax
            Car grandPrix = new Car()
            {
                CarYear = 2006,
                CarMake = "Pontiac", 
                CarModel = "Grand Prix",
                EngineNoise = "Nyoom",
                Horn = "meepmeep",
                IsDrivable = false

            };
            lot.CarList.Add(grandPrix);
            //Using the Constructor to allow parameter values to be placed inside properties.
            Car jeep = new Car(2018, "Jeep", "Cherokee", "vroom", "honkhonk", true);
            lot.CarList.Add(jeep);
            //Call Methods.
            fiat.MakeEngineNoise(fiat.EngineNoise);
            grandPrix.MakeEngineNoise(grandPrix.EngineNoise);
            jeep.MakeEngineNoise(jeep.EngineNoise);
          
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            foreach(var car in lot.CarList)
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {car.CarYear} Make: {car.CarMake} and Model: {car.CarModel}");
            }

        }
    }
}

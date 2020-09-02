using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable DONE
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()  DONE
        //The methods should take one string parameter: the respective noise property   DONE         

        public Car()
        {

        }
        public Car(int year, 
                   string make, 
                   string model, 
                   string engineNoise, 
                   string horn, 
                   bool isDrivable)
        {
            CarYear = year;
            CarMake = make;
            CarModel = model;
            EngineNoise = engineNoise;
            Horn = horn;
            IsDrivable= isDrivable;

        }

        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string EngineNoise { get; set; }
        public string Horn { get; set; }
        public bool IsDrivable { get; set; }
        
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
    
    }

}

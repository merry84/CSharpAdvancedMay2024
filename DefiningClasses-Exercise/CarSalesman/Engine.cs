
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        /*•	Model: a string property
        •	Power: an int property
        •	Displacement: an int property, it is optional
        •	Efficiency: a string property, it is optional
        */
        private string model;
        private int power;
        private int displacement;
        private string efficiency;
        public Engine()
        {
            Displasment = "n/a";
            Efficiency = "n/a";
        }
        public Engine(string model,int power ) : this()
        {
            Model = model;
            Power = power;
        }
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displasment { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            /*"{CarModel}:
              {EngineModel}:
                Power: {EnginePower}
                Displacement: {EngineDisplacement}
                Efficiency: {EngineEfficiency}
              Weight: {CarWeight}
              Color: {CarColor}"
                */
            return $"{Model}:\r\n"+
                   $"    Power: {Power}\r\n"+
                   $"    Displacement: {Displasment}\r\n"+
                   $"    Efficiency: {Efficiency}";
        }

    }
}

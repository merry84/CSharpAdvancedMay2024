using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        /*•	Model: a string property
        •	Engine: a property holding the engine object
        •	Weight: an int property, it is optional
        •	Color: a string property, it is optional
        */
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car()
        {
            Weight = "n/a";
            Color = "n/a";
        }
        public Car(string model,Engine engine) : this() 
        {
            Model = model;
            Engine = engine;    
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
                       
            return $"{Model}:\r\n" +
                   $"  {Engine}\n"+
                   $"  Weight: {Weight}\n"+
                   $"  Color: {Color}";
        }
    }
}

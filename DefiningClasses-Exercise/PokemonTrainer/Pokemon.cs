using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Pokemon
    {
        /*•	Name
        •	Element
        •	Health
        */
        private string name;
        private int health;
       
        private  string element;

        public Pokemon(string name,string element,int health)
        {
            Name = name;
            this.Element = element;
            this.Health = health;
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public string Element
        {
            get { return element; }
            set { element = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}

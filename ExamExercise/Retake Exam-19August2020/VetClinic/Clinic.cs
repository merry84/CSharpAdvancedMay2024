using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace VetClinic
{
    public class Clinic
    {
        private readonly List<Pet> pets;//~!?
        public Clinic(int capacity)
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }
        public int Capacity { get; set; }
        public int Count => pets.Count;
        public void Add(Pet pet)
        {
            //•	Method Add(Pet pet) – adds an entity to the data if there is an empty cell for the pet.
            if (Count < Capacity)
            {
                pets.Add(pet);
            }
        }
        //•	Method Remove(string name) – removes the pet by given name, if such exists, and returns bool.
        public bool Remove(string name)
        => pets.Remove(pets.FirstOrDefault(x => x.Name == name));
        //•	Method GetPet(string name, string owner)
        //– returns the pet with the given name and owner or null if no such pet exists.
        public Pet GetPet(string name, string owner)
        {
            return pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }
        //•	Method GetOldestPet() – returns the oldest Pet.
        public Pet GetOldestPet() => pets.OrderByDescending(x => x.Age).First();
        //
        /*•	GetStatistics() – returns a string in the following format:
            o	"The clinic has the following patients:
            Pet {Name} with owner: {Owner}
            Pet {Name} with owner: {Owner}
               (…)"
            */
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The clinic has the following patients:");
            foreach (Pet pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> racerList;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.racerList = new List<Racer>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        //•	Method Add(Racer Racer) – adds an entity to the data if there is room for him/her.
        public void Add(Racer Racer)
        {
            if (Capacity > Count)
            {
                racerList.Add(Racer);
            }
        }
        //•	Method Remove(string name) – removes a Racer by given name, if such exists, and returns bool.
        public bool Remove(string name)
        {
            return racerList.Remove(racerList.Find(x => x.Name == name));
        }

        //•	Method GetOldestRacer() – returns the oldest Racer.
        public Racer GetOldestRacer()
            => racerList.OrderByDescending(x => x.Age).First();
        //•	Method GetRacer(string name) – returns the Racer with the given name.
        public Racer GetRacer(string name)
            => racerList.Find(x => x.Name == name);
        //•	Method GetFastestRacer() – returns the Racer whose car has the highest speed.
        public Racer GetFastestRacer()
            => racerList.OrderByDescending(x => x.Car.Speed).First();
        //•	Getter Count – returns the number of Racers.
        public int Count => racerList.Count;

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}");
            foreach (var racer in racerList)
            {
                sb.AppendLine($"{racer}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

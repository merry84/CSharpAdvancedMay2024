using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> list {  get; set; }

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            list = new List<Ingredient>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        //•	Getter CurrentAlcoholLevel – returns the amount of alcohol currently in the cocktail.
        public int CurrentAlcoholLevel => list.Select(x => x.Alcohol).Sum();

        //•	Method Add(Ingredient ingredient) - adds the entity if there isn't an Ingredient with the same name and if there is enough space in terms of quantity and alcohol.
        public void Add(Ingredient ingredient)
        {
            if (!list.Any(x => x.Name == ingredient.Name) && Capacity > list.Count && ingredient.Alcohol + CurrentAlcoholLevel <= MaxAlcoholLevel)
            {
                list.Add(ingredient);
            }
        }
        //•	Method Remove(string name) - removes an Ingredient from the cocktail with the given name, if such exists and returns bool if the deletion is successful.
        public bool Remove(string name)
        => list.Remove(list.FirstOrDefault(x => x.Name == name));
        //•	Method FindIngredient(string name) - returns an Ingredient with the given name. If it doesn't exist, return null.
        public Ingredient FindIngredient(string name)
        => list.Find(x => x.Name == name);
        //•	Method GetMostAlcoholicIngredient() – returns the Ingredient with most Alcohol.
        public Ingredient GetMostAlcoholicIngredient()
            => list.OrderByDescending(x => x.Alcohol).FirstOrDefault();
        //•	Method Report() - returns information about the Cocktail and the Ingredients inside it in the following format:
        //"Cocktail: {name} - Current Alcohol Level: {CurrentAlcoholLevel}
        //{Ingredient1
        //    }
        //{Ingredient2
        //}
        //… "
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (Ingredient ingredient in list)
            {
                sb.AppendLine(ingredient.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}

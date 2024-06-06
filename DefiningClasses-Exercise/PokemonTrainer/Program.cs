namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new();
            string command;
            while ((command = Console.ReadLine())!= "Tournament" )
            {
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                //TrainerName is the name of the Trainer who caught the pokemon.Trainers' names are unique.
                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealth = int.Parse(info[3]);

                if (!trainers.ContainsKey(trainerName)) //ако няма създаваме нов терньор
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }
                trainers[trainerName].Pokemons.Add(new Pokemon(pokemonName,pokemonElement,pokemonHealth));

            }
            //For every command, you must check if a trainer has at least 1 pokemon with the given element.
            //If he does, he receives 1 badge. Otherwise, all of his pokemon lose 10 health. If a pokemon falls to 0 or less health,
            //he dies and must be deleted from the trainer's collection. In the end, you should print all of the trainers,
            //sorted by the number of badges they have in descending order (if two trainers have the same amount of badges,
            //they should be sorted by order of appearance in the input) in the format: 
         
            while ((command = Console.ReadLine())!="End")
            {
                string element = command;
                foreach (var trainer in trainers.Values) 
                {
                    if(trainer.Pokemons.Any(x=>x.Element == element))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach(var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                        trainer.Pokemons.RemoveAll(x=>x.Health  <= 0);
                    }
                }
            }
            foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                Console.WriteLine(trainer.Value);
            }

        }
    }
}

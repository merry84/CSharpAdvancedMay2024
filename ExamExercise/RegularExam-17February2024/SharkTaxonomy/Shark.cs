using System.Text;

namespace SharkTaxonomy
{
    public class Shark
    {
        /*First, create a class Shark with the following properties:
        •	Kind - string
        •	Length - int
        •	Food - string
        •	Habitat - string
        The class constructor should receive kind, length, food and habitat.
        Override the ToString() method in the following format:
        "{Kind} shark: {Length}m long.
        Could be spotted in the {Habitat}, typical menu: {Food}"
        */
       
        public Shark(string kind, int length, string food, string habitat)
        {
            Kind = kind;
            Length = length;
            Food = food;
            Habitat = habitat;

        }
        public string Kind { get ; set ; }
        public int Length { get; set ; }
        public string Food { get; set; }
        public string Habitat { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Kind} shark: {Length}m long.");
            sb.AppendLine($"Could be spotted in the {Habitat}, typical menu: {Food}");

            return sb.ToString().Trim();

        }
    }
}

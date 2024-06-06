using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {

        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }
        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }
        public int GetCount => Species.Count;

        /*•	Method AddShark(Shark shark) – adds a Shark to the Species collection, if the Capacity allows it. 
         * If there is a Shark from the same Kind already added, do not duplicate sharks, just skip the command.*/
        public void AddShark(Shark shark)
        {
            if (Capacity == Species.Count || Species.Any(s => s.Kind == shark.Kind))
            {
                return;
            }
            Species.Add(shark);

        }
        /*•	Method RemoveShark(string kind) – attempts to find a Shark, within the Species collection, 
         * with Kind value, matching the given parameter. 
         * If no Shark is found, the method returns false. Otherwise, it is removed from the collection and the method returns true.*/
        public bool RemoveShark(string kind)
        => Species.Remove(Species.FirstOrDefault(x => x.Kind == kind));
        /*•	Method GetLargestShark()– returns the ToString() value of the largest of all sharks, arranged by length.*/
        public string GetLargestShark()
            => Species.OrderByDescending(x => x.Length).FirstOrDefault().ToString();
        //ethod GetAverageLength() – returns the average length of the sharks added to the collection.
        public double GetAverageLength() => Species.Average(x => x.Length);
        /*•	Method Report() – returns a string in the following format:
        o	"{count} sharks classified:
        {shark1}
        {shark2}
        {…}
        {sharkn}"
        */

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{GetCount} sharks classified:");
            foreach (var shark in Species)
            {
                sb.AppendLine($"{shark.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}

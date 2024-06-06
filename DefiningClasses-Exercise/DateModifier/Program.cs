namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.Parse(Console.ReadLine());
            var endDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(DateModifier.Diff(startDate, endDate));
        }
    }
}

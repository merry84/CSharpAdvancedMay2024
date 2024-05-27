
int count = int.Parse(Console.ReadLine());


Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
for (int i = 0; i < count; i++)
{
    string[] infoStudent = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string name = infoStudent[0];
    decimal grade = decimal.Parse(infoStudent[1]);
    if (!students.ContainsKey(name))
    {
        students.Add(name, new List<decimal>());
    }
    students[name].Add(grade);//ако има такъв студент добави само оценката му

}
foreach (var student in students)
{
    Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(student => $"{student:f2}"))} (avg: {student.Value.Average():f2})");
}
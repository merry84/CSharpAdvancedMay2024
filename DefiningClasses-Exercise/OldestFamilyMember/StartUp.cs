using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
/*
3
Peter 3
George 4
Annie 5
*/
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            /*Write a program that reads the names and ages of N people and adds them to the family.
          * Then print the name and age of the oldest member.*/
            int countPeople = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < countPeople; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Person oldPerson = family.GetOldestMember();
            Console.WriteLine($"{oldPerson.Name} {oldPerson.Age}");


        }
    }
}

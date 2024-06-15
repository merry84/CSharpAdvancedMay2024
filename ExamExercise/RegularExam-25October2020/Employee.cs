using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BakeryOpenning
{
    public class Employee
    {/*•	Name: string
        •	Age: int
        •	Country: string
        The class constructor should receive name, age and country and override the ToString() method in the following format:
        "Employee: {name}, {age} ({country})"
        */
        public Employee(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"Employee: {Name}, {Age} ({Country})";
        }
    }
}

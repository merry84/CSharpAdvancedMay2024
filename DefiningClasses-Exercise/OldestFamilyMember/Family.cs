using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        /*Use your Person class from the previous tasks.
         * Create a class Family. 
         * The class should have a list of people, a method for adding members - void AddMember(Person member) 
         * and a method returning the oldest family member – Person GetOldestMember(). */

        private List<Person> familyNames;
        public Family()
        {
            familyNames = new List<Person>();
        }
        public List<Person> FamilyNames
        {
            get { return familyNames; }
            set { familyNames = value; }
        }

        public void AddMember(Person member)
        {
            FamilyNames.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldPerson = FamilyNames.MaxBy(x => x.Age);
            return oldPerson;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private readonly List<Student> students;
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count => students.Count;
        //•	Method RegisterStudent(Student student)
        //– adds an entity to the students if there is an empty seat for the student.
        //o Returns "Added student {firstName} {lastName}" if the student is successfully added
        //o Returns "No seats in the classroom" – if there are no more seats in the classroom
        public string RegisterStudent(Student student)
        {
            if (Capacity > Count)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else { return $"No seats in the classroom"; }
        }
        //•	Method DismissStudent(string firstName, string lastName) – removes the student by the given names
        //o Returns "Dismissed student {firstName} {lastName}" if the student is successfully dismissed
        //o Returns "Student not found" if the student is not in the classroom
        public string DismissStudent(string firstName, string lastName)
        {
            var student = students.Any(x => x.FirstName == firstName && x.LastName == lastName);
            if (student)
            {
                students.Remove(students.Find(x => x.FirstName == firstName && x.LastName == lastName));
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return $"Student not found";
            }

        }
        /*•	Method GetSubjectInfo(string subject)
         * – returns all the students with the given subject in the following format:
            "Subject: {subjectName}
            Students:
            {firstName} {lastName}
            {firstName} {lastName}
            …"
        o	Returns "No students enrolled for the subject" if the student is not in the classroom
            */
        public string GetSubjectInfo(string subject)
        {
            if (!students.Any(x => x.Subject == subject))
            {
                return $"No students enrolled for the subject";
            }
            var sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine($" Students:");
            foreach (var student in students)
            {
                sb.AppendLine($"{student.FirstName} {student.LastName}");
            }
            return sb.ToString().TrimEnd();
        }
        //•	Method GetStudentsCount() – returns the count of the students in the classroom.
        public int GetStudentsCount() => Count;
        //•	Method GetStudent(string firstName, string lastName) – returns the student with the given names. 
        public Student GetStudent(string firstName, string lastName)
            => students.Find(x => x.FirstName == firstName && x.LastName == lastName);
    }
}

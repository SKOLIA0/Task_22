using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task_22
{
    internal class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public static List<Person> ReadFromTextFile(string path)
        {
            var people = new List<Person>();
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                people.Add(new Person
                {
                    Name = parts[0],
                    DateOfBirth = DateTime.Parse(parts[1]),
                    PhoneNumber = parts[2]
                });
            }

            return people;
        }

        public static void WriteToTextFile(string path, List<Person> people)
        {
            var lines = people.Select(p => $"{p.Name},{p.DateOfBirth.ToShortDateString()},{p.PhoneNumber}");
            File.WriteAllLines(path, lines);
        }

        public static void AddPersonToFile(string path, Person person)
        {
            var line = $"{person.Name}, {person.DateOfBirth.ToShortDateString()}, {person.PhoneNumber}";
            File.AppendAllText(path, line + Environment.NewLine);
        }
    }
}

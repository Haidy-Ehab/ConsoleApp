using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public class Patient
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public priority Priority { get; set; }

            public Patient(int id, string name, priority priority)
            {
                Id = id;
                Name = name;
                Priority = priority;
            }

            public priority GetPriority()
            {
                return Priority;
            }

            public void PrintPatient()
            {
                Console.WriteLine($"Name: {Name} | ID: {Id} | {Priority}");
            }

            public override string ToString()
            {
                return $"Name: {Name} | ID: {Id} | {Priority}";
            }
        }
    }
}

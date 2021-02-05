using System;
using System.Collections.Generic;
using System.Text;

namespace DBEX
{
    public class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public string Hobbies { get; set; }

        public string Summary { get; set; }

        public Person()
        {
            Age = 33;
            Name = "Michiel";
            Hobbies = "Teaching";
            Summary = GetSummary();
        }

        

        private string GetSummary()
        {
            return $"{Name} is {Age} years old and likes {Hobbies}";
        }
    }
}

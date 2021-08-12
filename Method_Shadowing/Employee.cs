using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Shadowing
{
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string lastName, string company) : base(name, lastName)
        {
            Company = company;
        }
        public new void Display()
        {
            Console.WriteLine($"{Name} {LastName} in {Company}");
        }
    }
}

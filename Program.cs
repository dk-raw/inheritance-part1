using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //test comment lol
            Doctor d1 = new Doctor();
            d1.Name = "John Doe";
            d1.Age = 42;
            d1.Salary = 70000;
            d1.Status = "ACTIVE";
            d1.Building = "Operating Room";
            d1.Score = 10;
            d1.Degree = "Berlin Universtiy of Applied Sciences";
            d1.Printing();

            Nurse n1 = new Nurse();
            n1.Name = "Maria Doe";
            n1.Age = 31;
            n1.Salary = 20000;
            n1.Status = "ACTIVE";
            n1.Building = "ICU Building";
            n1.Score = 9.5;
            n1.Experiance = 6;
            n1.Printing();

            Retired_staff r1 = new Retired_staff();
            r1.Name = "Adams Doe";
            r1.Age = 89;
            r1.Status = "RETIRED";
            r1.Score = 10;

        }


    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        public string Building { get; set; }
        public double Score { get; set; }

        public void Printing()
        {
            Console.WriteLine($"{Name, -10} {Age, -5} {Status, -10} {Salary, -20} {Building, -30} {Score, -5}");
        }
    }
    class Doctor : Person
    {
        public string Degree { get; set; }
    }
    class Nurse : Person 
    {
        public int Experiance { get; set; }
    }
    class Retired_staff : Doctor
    {

    }
}

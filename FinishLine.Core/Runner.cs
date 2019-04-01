using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Runner
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get;  set; }
        public int Age { get;  set; }
        public string Gender { get;  set; }
        //public Country Country { get; set; }
        public string Country { get; set; }
        public int Lap { get; set; }
        public bool Win { get; set; }
        //public Runner(int iD, string name, string surname, int age, Gender gender, Country country)
        //{
        //    ID = iD;
        //    Name = name;
        //    Surname = surname;
        //    Age = age;
        //    Gender = gender;
        //    Country = country;
        //    Lap = 0;
        //    Win = false;
        //}

        public Runner()
        {
        }

        public Runner(int iD, string name, string surname, int age, string gender, string country)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Country = country;
        }
                
        //public enum Gender
        //{
        //    men,
        //    women
        //}


    }
}

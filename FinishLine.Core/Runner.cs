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
        public string Country { get; set; }
        public int Lap { get; set; }
        public bool Win { get; set; }     
        /// <summary>
        /// Constructor runner.
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="country"></param>
        public Runner(int iD, string name, string surname, int age, string gender, string country)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Country = country;
        }   
    }
}

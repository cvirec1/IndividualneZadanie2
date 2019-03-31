using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    class Runner
    {

        public int ID { get; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool Gender { get; private set; }
        public Country Country { get; set; }
        public int Lap { get; set; }
        public bool Win { get; set; }
        public Runner(int iD, string name, int age, bool gender, Country country)
        {
            ID = iD;
            Name = name;
            Age = age;
            Gender = gender;
            Country = country;
            Lap = 0;
            Win = false;
        }

        public Runner()
        {
        }

        private void EditRunner(string name,int age, bool gender, Country country, int lap, bool win)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Country = country;
            Lap = lap;
            Win = win;
        }

    }
}

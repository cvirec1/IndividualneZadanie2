using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RunRace
    {
        public int Laps { get; set; }
        public int LenghtLap { get; set; }
        public int Winners { get; set; }
        public DateTime time { get; set; }
        //create dictionary RunneList
        public Dictionary<int, Runner> RunnerList = new Dictionary<int, Runner>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="country"></param>
        public void AddRunner(int iD, string name,string surname, int age, string gender, string country)
        {
            Runner r = new Runner(iD,name,surname,age,gender,country);
            RunnerList.Add(r.ID, r);
        }

        public void AddRunnerToList(int iD,Runner runner)
        {            
            RunnerList.Add(runner.ID, runner);
        }

        public bool DeleteRunner(int id)
        {
            if (CheckRunner(id))
            {
                RunnerList.Remove(id);
                return true;
            }
            else
            {
                return false;
            }         
        }
        public void EditRunner(int id, string name, string surname, int age, string gender, string country)
        {
            if (CheckRunner(id))
            {                
                RunnerList[id].Name = name;
                RunnerList[id].Surname = surname;
                RunnerList[id].Age = age;
                RunnerList[id].Country = country;
                RunnerList[id].Gender = gender;
            }
            else
            {
               
            }

        }
        public bool CheckRunner(int id)
        {
            if (RunnerList.ContainsKey(id))
            {                
                return true;
            }
            else
            {
                return false;
            }
        }


        public int GetID()
        {
            Random rand = new Random();
            int someID = rand.Next(1, 999);
            while (CheckRunner(someID))
            {                
                someID = rand.Next(1, 999);
            }
            return someID;
        }

        public void StartRace(Dictionary<int,Runner> runnerList,DateTime dateTime)
        {
            Dictionary<int, Runner> newRunnerList = runnerList;
            TimeSpan time = new TimeSpan();
            

        }

    }
}

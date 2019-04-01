using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinishLine.Core
{
    public static class FileData
    {
        public static void SaveFile(string path,Dictionary<int,Runner> runnerList)
        {
            File.WriteAllLines(path, runnerList.Select(x =>  x.Key + "\t" + x.Value.Name + "\t"+x.Value.Surname+ "\t"+x.Value.Age+ "\t"+x.Value.Gender+"\t" + x.Value.Country).ToArray());

        }
        public static Dictionary<int, Runner> LoadRunnerList(string path)
        {
            Dictionary<int, Runner> LoadRunnerList = new Dictionary<int, Runner>();
            string[] importList = System.IO.File.ReadAllLines(path);           

            foreach (var rows in importList)
            {
                RunRace newRace = new RunRace();               
                string[] runnerList = rows.Split('\t');                                
                int id = int.Parse(runnerList[0]);
                string name = runnerList[1];
                string surname = runnerList[2];
                int age = int.Parse(runnerList[3]);
                string gender = runnerList[4];
                string country = runnerList[5];
                
                
                Runner newRunner = new Runner(id, name, surname, age, gender, country);
                
                LoadRunnerList.Add(id,newRunner);
            }
            return LoadRunnerList;
        }
        
    }
}

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
        
}
}

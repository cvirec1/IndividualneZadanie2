using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    static class RunRace
    {
        private static Dictionary<int, Runner> RunnerList = new Dictionary<int, Runner>();

        private static void AddRunner()
        {
            Runner r = new Runner();
            RunnerList.Add(r.ID, r);
        }
        private static bool DeleteRunner(int id)
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
        private static void EditRunner(int id)
        {
            if (CheckRunner(id))
            {               
                
            }
            else
            {
               
            }

        }
        private static bool CheckRunner(int id)
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
        
    }
}

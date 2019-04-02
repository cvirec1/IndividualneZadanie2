using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinishLine.Core;
namespace FinishLine
{
    public partial class RaceView : Form
    {
        public RaceView()
        {
            string pathfile = @"C:\Users\Public\Documents\data.txt";
            InitializeComponent();
            RunRace newRunRace = new RunRace();
            DateTime time = new DateTime();
            newRunRace.StartRace(FileData.LoadRunnerList(pathfile), time);
                                 
        }
    }
}

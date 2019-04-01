using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FinishLine.Core;
namespace FinishLine
{
    public partial class Form1 : Form
    {
        //string countryCreate;
        string path = @"c:\Users\valjasek\source\repos\IndividualneZadanie2\Data\countries.csv";
        string pathfile = @"C:\Users\Public\Documents\data.txt";
        RunRace runRace = new RunRace();
        public Form1()
        {
            InitializeComponent();
            cbxCountry.DataSource = LoadCountry.LoadCoutries(path);
            cbxCountry.DisplayMember = "EnglishShortName";
            cbxCountry.ValueMember = "CountryCode";
            cbxCountry.SelectedValue = "SK";
            cbxCountry.BindingContext = new BindingContext();
            cbxCountryEdit.DataSource = LoadCountry.LoadCoutries(path);
            cbxCountryEdit.DisplayMember = "EnglishShortName";
            cbxCountryEdit.ValueMember = "CountryCode";            
            cbxCountryEdit.BindingContext = new BindingContext();
            runRace.AddRunner(1, "name", "surname", 18, "men", "SK");
            dgwRunner.DataSource = runRace.RunnerList.Values.ToList<Runner>();

        }

        private void chbID_CheckedChanged(object sender, EventArgs e)
        {
            if (chbID.Checked == true)
            {
                lbID.Visible = true;
                nupdID.Visible = true;
            }
            else
            {
                lbID.Visible = false;
                nupdID.Visible = false;
            }
        }

        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
        }    
        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool success = false;
            int iD = runRace.GetID();
            if(chbID.Checked == true)
            {
                while(success)
                {
                    iD = (int)nupdID.Value;
                    success = runRace.CheckRunner(iD);
                }
            }
            
            string gender=null;         
            string name = tbxName.Text;
            string surname = tbxSurname.Text;
            int age = (int)nupdAge.Value;
            if (rbMale.Checked)
            {
                gender = "men";
            }
            if (rbFemale.Checked)
            {
                gender = "women";
            }
            string country = cbxCountry.SelectedValue.ToString();
            runRace.AddRunner(iD, name, surname, age, gender, country);
            dgwRunner.DataSource = runRace.RunnerList.Values.ToList<Runner>();
            txbNameEdit.Text = "";
            txbSurnameEdit.Text = "";
            nupAgeEdit.Value = nupAgeEdit.Minimum;
            cbxCountry.BindingContext = new BindingContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgwRunner.DataSource = runRace.RunnerList;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int iD;
            int.TryParse(txbEditID.Text, out iD);
            if (runRace.CheckRunner(iD))
            {
                btnCheck.BackColor = Color.Green;
                btnCheck.Text = "Verify";
                btnEdit.Enabled = true;
                txbNameEdit.Enabled = true;                
                txbSurnameEdit.Enabled = true;
                nupAgeEdit.Enabled = true;
                
                cbxCountryEdit.Enabled = true;
                btnEdit.Enabled = true;
                txbNameEdit.Text = runRace.RunnerList[iD].Name;
                txbSurnameEdit.Text = runRace.RunnerList[iD].Surname;
                nupAgeEdit.Value = runRace.RunnerList[iD].Age;
                if (runRace.RunnerList[iD].Gender == "men")
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
            }
            else
            {
                btnCheck.BackColor = Color.Red;
                btnCheck.Text = "Wrong ID";
                btnEdit.Enabled = false;
                txbNameEdit.Enabled = false;                
                txbSurnameEdit.Enabled = false;
                nupAgeEdit.Enabled = false;                
                cbxCountryEdit.Enabled = false;
            }
        }

        

        private void btnDeleteCheck_Click(object sender, EventArgs e)
        {
            int iD;
            int.TryParse(txbDelete.Text, out iD);
            if (runRace.CheckRunner(iD))
            {
                btnDeleteCheck.BackColor = Color.Green;
                btnDeleteCheck.Text = "Verify";
                btnDelete.Visible = true;
            }
            else
            {
                btnDeleteCheck.BackColor = Color.Red;
                btnDeleteCheck.Text = "Wrong ID";
                btnDelete.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int iD;
            int.TryParse(txbDelete.Text, out iD);
            runRace.DeleteRunner(iD);
            dgwRunner.DataSource = runRace.RunnerList.Values.ToList<Runner>();
        }

        private void toolStripNewRace_Click(object sender, EventArgs e)
        {
            FileData.SaveFile(pathfile, runRace.RunnerList);
            RaceView f = new RaceView();
            f.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string gender = null;
            int iD;
            int.TryParse(txbEditID.Text, out iD);
            string name = txbNameEdit.Text;
            string surname = txbSurnameEdit.Text;
            int age = (int)nupAgeEdit.Value;
            if (rbMale.Checked)
            {
                gender = "men";
            }
            if (rbFemale.Checked)
            {
                gender = "women";
            }
            string country = cbxCountryEdit.SelectedValue.ToString();
            runRace.EditRunner(iD, name, surname, age, gender, country);
            dgwRunner.DataSource = runRace.RunnerList.Values.ToList<Runner>();
            cbxCountryEdit.BindingContext = new BindingContext();            
        }

        private void rbMaleEdit_CheckedChanged(object sender, EventArgs e)
        {
            rbMale.Checked = true;
        }

        private void rbFemaleEdit_CheckedChanged(object sender, EventArgs e)
        {
            rbFemale.Checked = true;
        }

        private void toolStripSaveRace_Click(object sender, EventArgs e)
        {
            FileData.SaveFile(@"C:\Users\Public\Documents\data.txt", runRace.RunnerList);
        }

        //private void nupIdEdit_ValueChanged(object sender, EventArgs e)
        //{
        //    if (runRace.CheckRunner((int)nupIdEdit.Value))
        //    {
        //        nupIdEdit.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        nupIdEdit.BackColor = Color.Green;
        //    }
        //}

        private void nupdID_ValueChanged(object sender, EventArgs e)
        {
            if (runRace.CheckRunner((int)nupdID.Value))
            {
                nupdID.BackColor = Color.Red;
            }
            else
            {
                nupdID.BackColor = Color.Green;
            }
        }

        private void toolStripSetRace_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab(3);
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            runRace.Laps = (int)nupdLaps.Value;
            runRace.LenghtLap = (int)nupdLapsLenght.Value;
            runRace.Winners = (int)nupdWinner.Value;
        }

        private void toolStripLoadRace_Click(object sender, EventArgs e)
        {
            runRace.RunnerList.Clear();
            runRace.RunnerList = FileData.LoadRunnerList(pathfile);
            dgwRunner.DataSource = FileData.LoadRunnerList(pathfile).Values.ToList<Runner>();
        }
    }
}

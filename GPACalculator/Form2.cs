using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace GPACalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void submitCreditsButton_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string s_year = txtYear.Text;
            int year = 0;
            switch (s_year)
            {
                case "Freshman":
                case "freshman":
                case "1":
                    year = 1;
                    break;
                case "Sophomore":
                case "sophomore":
                case "2":
                    year = 2;
                    break;
                case "Junior":
                case "junior":
                case "3":
                    year = 3;
                    break;
                case "Senior":
                case "senior":
                case "4":
                    year = 4;
                    break;
                default:
                    MessageBox.Show("There was an error with the year you selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            //prepare new values for serialization
            decimal gradePercent = numGrade.Value / 100;
            decimal credits = numCredits.Value;
            bool isAP = isAPCheck.Checked;
            bool isHonors = isHonorsCheck.Checked;
            Grade grade = new Grade();
            grade.Name = name;
            grade.Year = year;
            grade.GradePercent = gradePercent;
            grade.Credits = credits;
            grade.IsAP = isAP;
            grade.IsHonors = isHonors;
            
            if (File.Exists("UserSaved.xml")) //runs if the xml file is generated
                //if(true)
            {
                //FileStream.Dispose();
                //prepare old values for re-serialization
                List<Grade> grades;
                grades = Grade.Deserialize("UserSaved.xml");
                grades.Add(grade);
                //Serialize
                Grade.Serialize("UserSaved.xml", grades);
            }
            else //runs if the xml file is not generated yet
            {
                grade.OriginalSerialize("UserSaved.xml");
            }

            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();

            this.Dispose();
        }
    }

    
}

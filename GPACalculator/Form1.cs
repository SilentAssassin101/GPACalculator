using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load_ListView();
            Load_Calculations();
        }

        private void overallValLabel_Click(object sender, EventArgs e)
        {
            //nothing
        }

        private void openForm2()
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Dispose();
        }

        private void creditManagementButton_Click(object sender, EventArgs e)
        {
            openForm2();
        }

        private void deleteAllClasses()
        {
            string delMessage = "Are you sure you want to permanently delete every class you have added? You will have to add them all back manually!";
            var confirmResult = MessageBox.Show(delMessage, "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                switch (File.Exists("UserSaved.xml"))
                {
                    case true:
                        File.Delete("UserSaved.xml");
                        Load_ListView();
                        break;
                    case false:
                        string noClassesExist = "You do not have any classes to delete";
                        MessageBox.Show(noClassesExist, "Error", MessageBoxButtons.OK);
                        break;
                }
            }
            else
            {
                //cancel
            }
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            deleteAllClasses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //I do not remember what this does
            //FUCK
        }

        private void Load_ListView()
        {
            listView1.Items.Clear();

            if (File.Exists("UserSaved.xml"))
            {
                List<Grade> grades;
                grades = Grade.Deserialize("UserSaved.xml");
                foreach (Grade grade in grades)
                {
                    string[] gradeString = new string[6];
                    gradeString[0] = grade.Name;
                    string yearName;
                    switch (grade.Year)
                    {
                        case 1:
                            yearName = "Freshman";
                            break;
                        case 2:
                            yearName = "Sophomore";
                            break;
                        case 3:
                            yearName = "Junior";
                            break;
                        case 4:
                            yearName = "Senior";
                            break;
                        default:
                            yearName = "Unknown";
                            break;
                    }
                    gradeString[1] = yearName;
                    gradeString[2] = (grade.GradePercent * 100).ToString() + "%";
                    gradeString[3] = grade.Credits.ToString();
                    gradeString[4] = grade.IsAP.ToString();
                    gradeString[5] = grade.IsHonors.ToString();

                    var listViewItem = new ListViewItem(gradeString);
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private void Load_Calculations()
        {
            if (!File.Exists("UserSaved.xml"))
            {
                return;
            }

            

            decimal freshTotalCredits = 0m;
            List<decimal> freshGPA = new List<decimal>();

            decimal sophTotalCredits = 0m;
            List<decimal> sophGPA = new List<decimal>();

            decimal juniorTotalCredits = 0m;
            List<decimal> juniorGPA = new List<decimal>();

            decimal seniorTotalCredits = 0m;
            List<decimal> seniorGPA = new List<decimal>();

            List<Grade> grades;
            grades = Grade.Deserialize("UserSaved.xml");

            foreach (Grade grade in grades)
            {
                switch (grade.Year.ToString())
                {
                    case "1":
                        {
                            freshTotalCredits = freshTotalCredits + grade.Credits;
                            freshGPA.Add(Calc_GPA(grade) * grade.Credits);
                            break;
                        }
                    case "2":
                        {
                            sophTotalCredits += grade.Credits;
                            sophGPA.Add(Calc_GPA(grade) * grade.Credits);
                            break;
                        }
                    case "3":
                        {
                            juniorTotalCredits += grade.Credits;
                            juniorGPA.Add(Calc_GPA(grade) * grade.Credits);
                            break;
                        }
                    case "4":
                        {
                            seniorTotalCredits += grade.Credits;
                            seniorGPA.Add(Calc_GPA(grade) * grade.Credits);
                            break;
                        }
                }
            }

            //get GPA's
            //freshman
            decimal fnl_freshGPA = avgGPA(freshGPA.Sum(), freshTotalCredits);
            decimal fnl_sophGPA = avgGPA(sophGPA.Sum(), sophTotalCredits);
            decimal fnl_juniorGPA = avgGPA(juniorGPA.Sum(), juniorTotalCredits);
            decimal fnl_seniorGPA = avgGPA(seniorGPA.Sum(), seniorTotalCredits);

            decimal overallTotalCredits = freshTotalCredits + sophTotalCredits + juniorTotalCredits + seniorTotalCredits;
            decimal fnl_totalGPA = avgGPA(freshGPA.Sum() + sophGPA.Sum() + juniorGPA.Sum() + seniorGPA.Sum(), overallTotalCredits);

            freshmanValLabel.Text = fnl_freshGPA.ToString();

            //debug bullshit
            //freshmanValLabel.Text = "10";
            //Console.WriteLine("Part 1 = " +  fnl_freshGPA.ToString());

            sophomoreValLabel.Text = fnl_sophGPA.ToString();
            juniorValLabel.Text = fnl_juniorGPA.ToString();
            seniorValLabel.Text = fnl_seniorGPA.ToString();
            overallValLabel.Text = fnl_totalGPA.ToString();

            reqCredits.Text = overallTotalCredits.ToString() + " / 22";
        }

        private decimal avgGPA(decimal rawGPASum, decimal totalCredits)
        {
            if (totalCredits != 0)
                return rawGPASum / totalCredits;
            else return 0;
        }

        private decimal Calc_GPA(Grade grade)
        {
            decimal amountAdd = 0;
            if (grade.IsAP && isUnweighted.Checked == false)
            {
                amountAdd = 1m;
            }
            else if (grade.IsHonors && isUnweighted.Checked == false)
            {
                amountAdd = 0.5m;
            }
            switch (grade.GradePercent * 100)
            {
                case >= 97.0m:
                    return 4.0m + amountAdd;
                case >= 93.0m:
                    return 4.0m + amountAdd;
                case >= 90.0m:
                    return 3.7m + amountAdd;
                case >= 87.0m:
                    return 3.3m + amountAdd;
                case >= 83.0m:
                    return 3m + amountAdd;
                case >= 80.0m:
                    return 2.7m + amountAdd;
                case >= 77.0m:
                    return 2.3m + amountAdd;
                case >= 73.0m:
                    return 2m + amountAdd;
                case >= 70.0m:
                    return 1.7m + amountAdd;
                case >= 67.0m:
                    return 1.3m + amountAdd;
                case >= 65.0m:
                    return 1.0m + amountAdd;
                case < 65.0m:
                    return 0m;
            }
        }

        private void overallLabel_Click(object sender, EventArgs e)
        {
            //nothing
        }

        //weighted?
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Load_ListView();
            Load_Calculations();
        }
    }
}
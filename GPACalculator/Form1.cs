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
            //do nothing
        }

        private void creditManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Dispose();
        }

        private void deleteAll_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                switch(grade.Year.ToString())
                {
                    case "1":
                        {
                            freshTotalCredits = freshTotalCredits + grade.Credits;
                            freshGPA.Add(Calc_GPA(grade));
                            break;
                        }
                    case "2":
                        {
                            sophTotalCredits += grade.Credits;
                            sophGPA.Add(Calc_GPA(grade));
                            break;
                        }
                    case "3":
                        {
                            juniorTotalCredits += grade.Credits;
                            juniorGPA.Add(Calc_GPA(grade));
                            break;
                        }
                    case "4":
                        {
                            seniorTotalCredits += grade.Credits;
                            seniorGPA.Add(Calc_GPA(grade));
                            break;
                        }
                }
            }

            //look here for errors
            //my guess is int -> decimal conversion error
            decimal a_freshGPA = freshGPA.Sum();
            decimal a_sophGPA = sophGPA.Sum();
            decimal a_juniorGPA = juniorGPA.Sum();
            decimal a_seniorGPA = seniorGPA.Sum();

            decimal a_totalGPA = a_freshGPA + a_sophGPA + a_juniorGPA + a_seniorGPA;
            decimal overallTotalCredits = freshTotalCredits + sophTotalCredits + juniorTotalCredits + seniorTotalCredits;

            decimal b_freshGPA = 0;
            if (freshTotalCredits != 0)
            {
                b_freshGPA = a_freshGPA / freshTotalCredits;
            }
            decimal b_sophGPA = 0;
            if (sophTotalCredits != 0)
            {
                b_sophGPA = a_sophGPA / sophTotalCredits;
            }
            decimal b_juniorGPA = 0;
            if (juniorTotalCredits != 0)
            {
                b_juniorGPA = a_juniorGPA / juniorTotalCredits;
            }
            decimal b_seniorGPA = 0;
            if (seniorTotalCredits != 0)
            {
                b_seniorGPA = a_seniorGPA / seniorTotalCredits;
            }
            decimal b_totalGPA = 0;
            if (overallTotalCredits != 0)
            {
                b_totalGPA = a_totalGPA / overallTotalCredits;
            }
                
            overallValLabel.Text = b_totalGPA.ToString();
            freshmanValLabel.Text = b_freshGPA.ToString();
            sophomoreValLabel.Text = b_sophGPA.ToString();
            juniorValLabel.Text = b_juniorGPA.ToString();
            seniorValLabel.Text= b_seniorGPA.ToString();
            reqCredits.Text = overallTotalCredits.ToString() + " / 22";
        }

        private decimal Calc_GPA(Grade grade)
        {
            decimal amountAdd = 0;
            if(grade.IsAP)
            {
                amountAdd = 1m;
            }
            else if (grade.IsHonors)
            {
                amountAdd = 0.5m;
            }
            switch (grade.GradePercent)
            {
                case >= 97m:
                    return 4.0m + amountAdd;
                case >= 93m:
                    return 4.0m + amountAdd;
                case >= 90m:
                    return 3.7m + amountAdd;
                case >= 87m:
                    return 3.3m + amountAdd;
                case >= 83m:
                    return 3m + amountAdd;
                case >= 80m:
                    return 2.7m + amountAdd;
                case >= 77m:
                    return 2.3m + amountAdd;
                case >= 73m:
                    return 2m + amountAdd;
                case >= 70m:
                    return 1.7m + amountAdd;
                case >= 67m:
                    return 1.3m + amountAdd;
                case >= 65m:
                    return 1.0m + amountAdd;
                case < 65:
                    return 0m;
            }
        }

        private void overallLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GPACalculator
{
    [Serializable]
    public class Grade
    {
        #region Member Variables
        //public Guid ID;
        public string Name;
        public int Year;
        public decimal GradePercent;
        public decimal Credits;
        public decimal GPA;
        public decimal Effect_GPA;
        public bool IsAP;
        public bool IsHonors;
        #endregion

        #region Constructors
        public Grade()
        {
            //ID = Guid.NewGuid();

            //GPA CALCULATOR NEEDED
            //mEffect_GPA = mGPA * mCredits;
        }
        #endregion

        #region Serialization
        public static void Serialize(string fileName, List<Grade> grades)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Grade>));
            using (TextWriter writer = new StreamWriter(@fileName))
            {
                serializer.Serialize(writer, grades);
            }
        }

        public static List<Grade> Deserialize(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Grade>));
            FileStream stream = new FileStream(fileName, FileMode.Open);
            List<Grade> f_return = (List<Grade>)serializer.Deserialize(stream);
            stream.Close();
            return f_return;
        }

        //Old For Safe Keeping
        /*public void OriginalSerialize(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Grade));
            using (TextWriter writer = new StreamWriter(@fileName))
            {
                serializer.Serialize(writer, this);
            }
        }*/

        public void OriginalSerialize(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Grade>));
            using (TextWriter writer = new StreamWriter(@fileName))
            {
                List<Grade> f_grades = new List<Grade>
                {
                    this
                };
                serializer.Serialize(writer, f_grades);
            }
        }
        #endregion

    }
}

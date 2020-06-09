using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp2
{

    /// <summary>
    /// This is an abstract class, has a name and a date of birth
    /// </summary>
    /// <param name="repeat">Name and berthday</param>
    /// <returns>class itself</returns>
    [Serializable]
    [XmlInclude(typeof(Student))]
    [XmlInclude(typeof(Lecturer))]
    [XmlInclude(typeof(Applicant))]
    public abstract class Persona
    {
        public Persona()
        {
            Name = "af";
            DateOfBirth = new DateTime();
        }
        /// <summary>
        /// This is an abstract class, has a name and a date of birth
        /// </summary>
        /// <param name="repeat">Name and berthday</param>
        /// <returns>class itself, new</returns>
        public Persona(string name, string dateOfBirht)
        {
            Name = name;
            string[] dateArr = dateOfBirht.Split('.');
            DateOfBirth = new DateTime(Int32.Parse(dateArr[2]), Int32.Parse(dateArr[1]), Int32.Parse(dateArr[0]), 0, 0, 0);
        }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public abstract void outInfo();

        /// <summary>
        /// This method counts age.
        /// </summary>
        /// <returns>age in years</returns>
        public int Age()
        {
            return (int)(DateTime.Now.Subtract(DateOfBirth).TotalDays / 365);
        }
    }
}

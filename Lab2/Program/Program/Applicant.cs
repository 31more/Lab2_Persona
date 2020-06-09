using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    ///Applicant class
    /// </summary>
    [Serializable]
    public class Applicant : Persona
    {
        public Applicant()
        : base()
        {
            Faculty = "asd";
        }
        /// <summary>
        /// This is a class constructor
        /// </summary>
        /// <param name="repeat">Name, date of birth, faculty</param>
        /// <returns>Class itself, new</returns>
        public Applicant(string name, string dateOfBorth, string faculty)
            : base(name, dateOfBorth)
        {
            Faculty = faculty;
        }

        public string Faculty;
        /// <summary>
        /// This is the method of displaying all the information.
        /// </summary>
        public override void outInfo()
        {
            Console.WriteLine("Age: " + Age() + ", Surname: " + Name + ", Date of birth: " + DateOfBirth.ToShortDateString() + ", Faculty: " + Faculty);
        }
    }
}

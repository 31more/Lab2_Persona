using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// Lecturer class
    /// </summary>
    [Serializable]
    public class Lecturer : Persona
    {
        public Lecturer()
            : base()
        {
            Position = "afs";
            Faculty = "asfa";
        }
        /// <summary>
        /// This is a class constructor
        /// </summary>
        /// <param name="repeat">Name, date of birth, faculty, position, length of service </param>
        /// <returns>new class</returns>
        public Lecturer(string name, string dateOfBorth, string faculty, string position, string experience)
          : base(name, dateOfBorth)
        {
            Faculty = faculty;
            Position = position;
            Experience = experience;
        }
        public string Position;
        public string Faculty;
        public string Experience;
        /// <summary>
        /// This is the method of displaying all the information.
        /// </summary>
        public override void outInfo()
        {
            Console.WriteLine("Age: " + Age() + ", Surname: " + Name + ", Date of birth: " + DateOfBirth.ToShortDateString() + ", faculty: " + Faculty + ", Position: " + Position + ", Length of servic: " + Experience);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// Student class
    /// </summary>
    [Serializable]
    public class Student : Persona
    {
        public Student()
             : base("Ivanov", "01.01.2001")
        {
            Faculty = "def";
            Cours = 1;
        }
        /// <summary>
        /// This is a class constructor
        /// </summary>
        /// <param name="repeat">Name, date of birth, faculty, course</param>
        /// <returns>New class</returns>
        public Student(string name, string dateOfBorth, string faculty, int cours)
          : base(name, dateOfBorth)
        {
            Faculty = faculty;
            Cours = cours;
        }

        public string Faculty;
        public int Cours;
        /// <summary>
        /// Это метод выводи всю инф-цию
        /// </summary>
        public override void outInfo()
        {
            Console.WriteLine("Age: " + Age() + ", Surname: " + Name + ", Date of birth " + DateOfBirth.ToShortDateString() + ", Faculty: " + Faculty + ", Cours: " + Cours);
        }
    }
}

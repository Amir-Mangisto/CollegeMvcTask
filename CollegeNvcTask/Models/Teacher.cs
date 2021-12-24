using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeNvcTask.Models
{
    public class Teacher
    {
        public int id;
        public string fullName;
        public int salary;
        public int yearsOfWork;
        public string[] proffesion;

        public Teacher(int id, string fullName, int salary, int yearsOfWork, string[] proffesion)
        {
            this.id = id;
            this.fullName = fullName;
            this.salary = salary;
            this.yearsOfWork = yearsOfWork;
            this.proffesion = proffesion;
        }
        public static List<Teacher> teacherList = new List<Teacher>();
    }
}
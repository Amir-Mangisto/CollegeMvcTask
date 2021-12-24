using CollegeNvcTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollegeNvcTask.Controllers.API
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(Student.stuList);
            }
            catch
            {
                return Ok("sorry student wasnt found");
            }
        }

        private static List<Student> ShowStudentsList()
        {
            Student[] students = new Student[]
            {
                new Student(0,"dan madan",6,2000,new string[] {"80","90"}),
                new Student(1,"bady many",8,2002,new string[] {"90","65" }),
                new Student(2,"david max",10,2005,new string[] {"100","100"})
            };
            Student.stuList.AddRange(students);
            return Student.stuList;
        }

        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                ShowStudentsList();
                Student stu1 = Student.stuList.Find(stuItem => stuItem.id == id);
                return Ok(stu1);
            }
            catch
            {
                return Ok("sorry insert id again");
            }
        }

        // POST: api/Student
        public IHttpActionResult Post([FromBody] Student value)
        {
            try
            {
                ShowStudentsList();
                Student.stuList.Add(value);
                return Ok(Student.stuList);
            }
            catch
            {
                return Ok("sorry try again");
            }
        }

        // PUT: api/Student/5
        public IHttpActionResult Put(int id, [FromBody] Student value)
        {
            try
            {
                ShowStudentsList();
                Student getStu = Student.stuList.Find(item => item.id == id);
                Student.stuList[Student.stuList.IndexOf(getStu)].fullName = value.fullName;
                Student.stuList[Student.stuList.IndexOf(getStu)].grade = value.grade;
                Student.stuList[Student.stuList.IndexOf(getStu)].birthYear = value.birthYear;
                Student.stuList[Student.stuList.IndexOf(getStu)].grades = value.grades;
                return Ok(Student.stuList);
            }
            catch
            {
                return Ok("sorry try again");
            }
        }

        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Student Remove = Student.stuList.Find(item => item.id == id);
                Student.stuList.Remove(Remove);
                return Ok(Student.stuList);
            }
            catch
            {
                return Ok("sorry try again");
            }
        }
    }
}

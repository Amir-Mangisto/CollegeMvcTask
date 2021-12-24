using CollegeNvcTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollegeNvcTask.Controllers.API
{
    public class TeacherController : ApiController
    {
        // GET: api/Teacher
        public IHttpActionResult Get()
        {
            try
            {

                return Ok(Teacher.teacherList);
            }
            catch
            {
                return Ok("sorry try again");
            }
        }

        private static List<Teacher> ShowTeacherList()
        {
            Teacher[] list = new Teacher[]
            {
                new Teacher(0,"moshes eli",7000,1999,new string[]{"History","English"}),
                new Teacher(1,"james michael",5500,2002,new string[] {"Math","Sport"}),
                new Teacher(2,"jacob  ingi",10000,2017,new string[]{"full stuck","data base"})
            };
            Teacher.teacherList.AddRange(list);
            return Teacher.teacherList;
        }

        // GET: api/Teacher/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                ShowTeacherList();
                Teacher teacher = Teacher.teacherList.Find(item => item.id == id);
                return Ok(teacher);
            }
            catch
            {
                return Ok("insert id again");
            }
        }

        // POST: api/Teacher
        public IHttpActionResult Post([FromBody] Teacher value)
        {
            try
            {
                ShowTeacherList();
                Teacher.teacherList.Add(value);
                return Ok(value);
            }
            catch
            {
                return Ok("try again");
            }
        }

        // PUT: api/Teacher/5
        public IHttpActionResult Put(int id, [FromBody] Teacher value)
        {
            try
            {
                Teacher getTeacher = Teacher.teacherList.Find(item => item.id==id);
                Teacher.teacherList[Teacher.teacherList.IndexOf(getTeacher)].id = value.id ;
                Teacher.teacherList[Teacher.teacherList.IndexOf(getTeacher)].fullName = value.fullName;
                Teacher.teacherList[Teacher.teacherList.IndexOf(getTeacher)].salary = value.salary;
                Teacher.teacherList[Teacher.teacherList.IndexOf(getTeacher)].yearsOfWork = value.yearsOfWork;
                Teacher.teacherList[Teacher.teacherList.IndexOf(getTeacher)].proffesion = value.proffesion;

                return Ok(Teacher.teacherList);
            }
            catch
            {
                return Ok("try again");
            }
        }

        // DELETE: api/Teacher/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Teacher remove = Teacher.teacherList.Find(item => item.id == id);
                Teacher.teacherList.Remove(remove);
                return Ok(Teacher.teacherList);
            }
            catch
            {
                return Ok("sorry Teacher wasnt remove");
            }
        }
    }
}

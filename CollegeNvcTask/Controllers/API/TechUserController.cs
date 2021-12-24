using CollegeNvcTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollegeNvcTask.Controllers.API
{
    public class TechUserController : ApiController
    {

        // GET: api/TechUser
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(TechUser.usersList);
            }
            catch
            {
                return Ok("sorry try again");
            }
        }


        private List<TechUser> ShowUser()
        {
            TechUser[] users = new TechUser[]
            {
                new TechUser(0,"amir",8,1996,"yes"),
                new TechUser(1,"dan",10,1997,"yes"),
                new TechUser(2,"eli",11,1998,"yes")
            };
            TechUser.usersList.AddRange(users);
            return TechUser.usersList;
        }

        // GET: api/TechUser/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                ShowUser();
                TechUser user = TechUser.usersList.Find(item => item.Id == id);
                return Ok(user);
            }
            catch
            {
                return Ok("sorry try again");
            }
        }

        // POST: api/TechUser
        public IHttpActionResult Post([FromBody] TechUser value)
        {
            try
            {
                ShowUser();
                TechUser.usersList.Add(value);
                return Ok(TechUser.usersList);
            }
            catch
            {
                return Ok("sorry try again");
            }
        }

        // PUT: api/TechUser/5
        public IHttpActionResult Put(int id, [FromBody] TechUser value)
        {
            try
            {
                ShowUser();
                TechUser myUser = TechUser.usersList.Find(item => item.Id == id);
                TechUser.usersList[TechUser.usersList.IndexOf(myUser)].Id = value.Id;
                TechUser.usersList[TechUser.usersList.IndexOf(myUser)].Name = value.Name;
                TechUser.usersList[TechUser.usersList.IndexOf(myUser)].Kita = value.Kita;
                TechUser.usersList[TechUser.usersList.IndexOf(myUser)].Birth = value.Birth;
                TechUser.usersList[TechUser.usersList.IndexOf(myUser)].IsConected = value.IsConected;
                return Ok(TechUser.usersList);
            }
            catch
            {
                return Ok("sorry try again");
            }
        }

        // DELETE: api/TechUser/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                TechUser remove = TechUser.usersList.Find(item => item.Id == id);
                TechUser.usersList.Remove(remove);
                return Ok(TechUser.usersList);
            }
            catch
            {
                return Ok("sorry try again");
            }
        }
    }
}

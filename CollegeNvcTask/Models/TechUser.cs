using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeNvcTask.Models
{
    public class TechUser
    {
        public static List<TechUser> usersList=new List<TechUser>();
        public TechUser(int id, string name, int kita, int birth, string isConected)
        {
            Id = id;
            Name = name;
            Kita = kita;
            Birth = birth;
            IsConected = isConected;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Kita { get; set; }
        public int Birth { get; set; }
        public string IsConected { get; set; }

    }
}
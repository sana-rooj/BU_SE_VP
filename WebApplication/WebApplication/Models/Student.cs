using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }

        public void InitializeStudent()
        {
            id = 10;
            name = "Awais";
        }
    }
}
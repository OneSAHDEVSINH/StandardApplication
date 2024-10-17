using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandardApplication.DAL
{
    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public int CityId { get; set; }
        public string Hobbies { get; set; }
    }
}
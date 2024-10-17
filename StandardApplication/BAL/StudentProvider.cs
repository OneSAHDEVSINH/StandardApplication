using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StandardApplication.DAL;

namespace StandardApplication.BAL
{
    public class StudentProvider
    {
        public List<Student> Students;
        public StudentProvider() {
            Students = new List<Student>()
            {
                new Student(){Name="Sahdevsinh", Gender='M', Address="Shahibaug",CityId=1, Hobbies="Sports, Music"},
                new Student(){Name="Krupa", Gender='F', Address="Bopal",CityId=2, Hobbies="Reading"},
                new Student(){Name="Ankit", Gender='M', Address="Gota",CityId=3, Hobbies = "Swimming, Music"},
                new Student(){Name="Dhruvi", Gender='F', Address="Vastral",CityId=4, Hobbies = "Sports, Reading"},
                new Student(){Name="Vrushibh", Gender='M', Address="Prahladnagar",CityId=5, Hobbies = "Music"},
                new Student(){Name="Mohit", Gender='M', Address="Sarkhej",CityId=5, Hobbies = "Sports"},
                new Student(){Name="Hit", Gender='M', Address="Thaltej",CityId=4, Hobbies = "Sports, Swimming"},
                new Student(){Name="Senorita", Gender='F', Address="Nikol",CityId=3, Hobbies = "Swimming"},
                new Student(){Name="Dax", Gender='M', Address="Naroda",CityId=2, Hobbies = "Sports"},
                new Student(){Name="Vaishali", Gender='F', Address="Narol",CityId=1, Hobbies = "Music, Sports"},
            };
        }
        public List<Student> SearchByGender(char gender)
        {
            List<Student> list = new List<Student>();
            foreach(Student s in Students)
            {
                if (s.Gender == gender)
                list.Add(s);
            }
            return list;
        }
        public List<Student> SearchByCity(int cityId)
        {
            List<Student> students = new List<Student>();
            foreach (Student s in Students)
            {
                if(s.CityId == cityId)
                {
                    students.Add(s);
                } 
            }
            return students;
        }
        public List<Student> SearchByHobbies(string hobbies)
        {
            List<Student> students = new List<Student>();
            foreach (Student s in Students)
            {
                if (s.Hobbies.Contains(hobbies))
                {
                    students.Add(s);
                }
            }
            return students;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Telebe_haqqinda
{
    class Student
    {
        public string Name;
        public string Surname;
        public string Course;
        public string Subject;
        public string University;
        public string Email;
        public int PhoneNumber;
        public int Age;
        public string Gender;
        public string Adress;
        public string StudentAbout;

        public Student(string name, string surname, string course, string subject, string university, string email, int phonenumber)
        {
            Name = name;
            Surname = surname;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            PhoneNumber = phonenumber;
        }
        public Student(int age,string gender)
        {
            Age = age;
            Gender = gender;
        }
        public Student(string adress, string studentabout)
        {
            Adress = adress;
            StudentAbout = studentabout;
            
        }
        public Student()
        {

        }
        public void Student1()
        {
            Console.WriteLine($"{Name} {Surname} {Course} {Subject} {University} {Email} {PhoneNumber}");
            Console.WriteLine($"{Age} {Gender}");
            Console.WriteLine($"{Adress} {StudentAbout}");
        }
    }
}

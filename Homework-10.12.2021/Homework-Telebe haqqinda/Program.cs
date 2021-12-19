using System;

namespace Homework_Telebe_haqqinda
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1.Name = "Amil";
            stu1.Surname = "Nuriyev";
            stu1.Course = "Academy";
            stu1.Subject = "Developer";
            stu1.University = "Code Academy";
            stu1.Email = "anuriyev008@gmail.com";
            stu1.PhoneNumber = (0773019691);
            stu1.Age = (17);
            stu1.Gender = "Kisi";
            stu1.Adress = "Baku,Azerbaycan";
            stu1.StudentAbout = "Amil Nuriyev 17 yasi var orta mektebi bitirdikden sonra Code Academye daxil olub.";
            stu1.Student1();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string Positon;
        public int DailySalary;
        public int MontlySalary;


        public Employee(string name, string surname, string positon, int dailysalary)
        {
            int m = 30;
            Name = name;
            Surname = surname;
            Positon = positon;
            DailySalary = dailysalary;
            MontlySalary = DailySalary * m;
        }

        public void Employee1()
        {
            Console.WriteLine(MontlySalary);
        }
    }
}

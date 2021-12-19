using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Greet();

            Student student1 = new Student();
            student1.Study();
            student1.Greet();
            student1.ShowAge();
            student1.SetAge(20);

            Teacher teacher1 = new Teacher();
            teacher1.Explain();
            teacher1.Greet();
            teacher1.SetAge(25);
        }
    }
}

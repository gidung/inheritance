using System;

namespace LatihanInheritanceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Huda", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Jarwo", 35, 190302, "Guru Matematika");
            teacher.GetNameAndAge();

            Student student = new Student("Budi", 21, 10506, "gidung.id@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}

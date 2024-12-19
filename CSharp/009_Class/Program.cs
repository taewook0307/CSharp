using MyClass;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student NewStudent = new Student("Bibi", 18, 'A');
            StudentManager.GetManager().RegistStudent("Nami", 17, 'B');
            StudentManager.GetManager().RegistStudent("Zoro", 17, 'B');
            StudentManager.GetManager().RegistStudent("Rupy", 17, 'B');
            StudentManager.GetManager().RegistStudent("Robbin", 17, 'B');
            StudentManager.GetManager().RegistStudent(NewStudent);

            Student findStudent = StudentManager.GetManager().FindStudent("Zoro");
            findStudent.PrintStudentInfo();
        }
    }
}

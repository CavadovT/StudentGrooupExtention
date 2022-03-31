using System;
using StudentGrooupExtention.Models;

namespace StudentGrooupExtention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            Student stu1 = new Student("Tural","Cavadov",80);
            group.AddStudent(stu1);
            Student stu2 = new Student("Abbaseli", "Abbasov", 90);
            group.AddStudent(stu2);
                group.GetAllStudents();

           
        }
    }
}

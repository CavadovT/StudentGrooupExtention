using System;
using System.Text;
using StudentGrooupExtention.Models;

namespace StudentGrooupExtention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                   1.3 Program class
            a) 4 dənə student obyekti yaradın qarışıq point dəyərlərində.
            b) Group obyekti yaradın və group obyektinə AddStudent methodundan istifadə edərək studentləri əlavə edin.
            c) GetAllStudents methodundan istifadə edərək bütün studentləri ekrana çıxardın.
            d) Sort methodundan istifadə edərək sort olunmuş studentləri ekrana çıxardın.
            e) İkinci bir Group obyketi yaradın və qrup nömrəsinin avtomatik artmağını yoxlayın.
          */
            do
            {
                Student s1 = new Student("Tural", "Cavadov", 100);
                Student s2 = new Student("Mamemd", "Mamedov", 90);
                Student s3 = new Student("Abbas", "Abbasov", 70);
                Student s4 = new Student("Ageli", "Ageliyev", 80);

                Group group = new Group("AA101");
                group.AddStudent(s1);
                group.AddStudent(s2);
                group.AddStudent(s3);
                group.AddStudent(s4);

                group.GetAllStudents();
                group.Sort();

            } while (Console.ReadKey().Key != ConsoleKey.Escape);






        }
    }
}

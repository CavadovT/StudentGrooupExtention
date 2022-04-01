using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGrooupExtentions.Models
{
    internal class Student// hazirdi
    {
        /*
         1.1 Student class
            - Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və 
        hər dəfə yeni bir Student obyekt yaradıldıqda avtomatik bir vahid artacaq.
            - Name
            - Surname
            - Age
            - Point
            - ShowInfo() - student-in bütün məlumatlarını geriyə qaytaracaq.
            
            '>' və '<' operatorları üçün operator overloading yazırsız və Point dəyərlərini müqayisə edir.
            
            ps: Name, surname, point dəyərləri olmadan student obyekti yaratmaq olmaz
         
         */
        private static int _id;
        public readonly int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
        public Student(string name,string surname, int point)
        {
            _id++;
            Id= _id;
            Name = name;
            Surname = surname;
            Point = point;

        }
        public static bool operator >(Student s1, Student s2)
        {
            return (s1.Point > s2.Point);
        }
        public static bool operator <(Student s1, Student s2)
        {
            return (s1.Point < s2.Point);

        }
    }
}

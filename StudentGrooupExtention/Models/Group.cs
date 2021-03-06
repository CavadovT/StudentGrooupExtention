using System;
using System.Collections.Generic;
using System.Text;



namespace StudentGrooupExtentions.Models
{
    internal class Group
    {
        /*
                    1.2 Group class
           - No - qıraqdan set etmək olmayacaq yalnız get etmək olacaq hər dəfə yeni bir Group obyekt yaradıldıqda 
           avtomatik qrup nömrəsinin rəqəm hissəsi bir vahid artacaq ilk yaradılacaq qrupun 
           qrup nönmrəsi AP101 olacaq ikinci dəfə qrup yaradan zaman avtomatik AP102 olacaq bu şəkildə 
               hər dəfə yeni qrup yaradılanda rəqəm hissəsi artacaq.

           - Students array - private olacaq, Student obyektilərini özündə saxlayacaq.
           - AddStudent() - bu metod studnet type-da studnet qebul edir ve Students array-e elave edir.
           - GetAllStudents() - geriyə bütün studentləri qaytaracaq.
           - Sort() - parametr olaraq heç nə qəbul etməyəcək, Students arrayindəki studentləri 
        Point dəyərlərinə görə sort edib(azdan çoxa sıralamaq) geriyə bir Student tipindən sort olunmuş bir array qaytaracaq

           Sort methodundan istifadə edərkən bir başa students array-i üzərində sort əməliyyatını aparmayın
        students arrayinin bir copy-ni yaradın onun üzərində sort əməliyyatı aparın və geriyə həmin copy olunmuş arrayi qaytarın.

        */
        private static int _no = -1;

        public readonly string No;
        private Student[] students;
        private Student[] studentscopy;
        
        public Group()
        {
            students = new Student[0];
            No = "AP101";
            _no++;
            string strword = No.Remove(2);//AP
            string strcopy1= No.Replace('A', '0');//0P101
            string strcopy2 = strcopy1.Replace('P', '0');//00101
            string strcopy = strcopy2;
            int numisstr = int.Parse(strcopy);//101
            
            No = strword + (numisstr+_no).ToString();//AP101

        }

        public object Extention { get; private set; }

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
            Console.WriteLine($"{student.Name}  added to {No}.th group");   
           studentscopy=students;
           
         
        }
        public void GetAllStudents()
        {
            Console.WriteLine();
            foreach (Student item in students) 
            {
                Console.WriteLine($"ID:{item.Id} , NAME: {item.Name}  ,  SURNAME: {item.Surname}  ,  AGE: {item.Age}  ,  POINT: {item.Point}");
            }
            Console.WriteLine();
        }
       
        public void Sort() 
        {
          Student minstu = studentscopy[0];
            for (int i = 0; i < studentscopy.Length; i++)
            {
                for (int j = i + 1; j < studentscopy.Length; j++)
                {
                    if (studentscopy[i].Point > studentscopy[j].Point)
                    {
                        minstu = studentscopy[j];
                        studentscopy[j] = studentscopy[i];
                        studentscopy[i] = minstu;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("Sort of students at min point to max point");
            foreach (Student item in studentscopy) 
            {
            Console.WriteLine($"ID:{item.Id} , NAME: {item.Name}  ,  SURNAME: {item.Surname}  ,  AGE: {item.Age}  ,  POINT: {item.Point}");   
            }
            Console.WriteLine();

        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class Student:IComparable<Student>
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int ClassNo { get; set; }
        public int Marks { get; set; }

        public Student(int studentId, string name, int classno, int marks){
            this.StudentId=studentId;
            this.Name=name;
            this.ClassNo=classno;
            this.Marks=marks;
            }

        public int CompareTo(Student? other)
        {
            if(this.StudentId>other.StudentId)
                return 1;
            else if(this.StudentId<other.StudentId)
                return -1;
            else
                return 0;
        }
    }


    class CompareStudents : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x.Marks > y.Marks)
            {
                return 1;
            }
            else if (x.Marks < y.Marks)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }


    class TestClass
    {
        public static int CompareNames(Student s1,Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }
        static void Main()
        {
            Student s1=new Student(101,"Sameer",10,90);
            Student s2=new Student(102,"Rahul",10,80);
            Student s3=new Student(104,"Raj",10,70);
            Student s4=new Student(103,"Ravi",10,60);

            List<Student> Students= new List<Student>() { s1, s2, s3, s4 };
            //Students.Sort();

            //CompareStudents compareStudents = new CompareStudents();
            //Students.Sort(compareStudents);
            // Students.Sort(1,3, compareStudents);

            Comparison < Student > obj = new Comparison<Student>(CompareNames);
            Students.Sort(obj);

            foreach(Student s in Students)
            {
                Console.WriteLine(s.StudentId+" "+s.Name+" "+s.ClassNo+" "+s.Marks);
            }
        }
    }
}

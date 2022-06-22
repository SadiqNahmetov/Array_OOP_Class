using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    class Student
    {
        
        public string name;
        public string surname;
        public int age;
        public string address;


        //public Student(int age, string address) : this(address)
        //  {
        //     //this.address = address;
        //     Console.WriteLine("Age" + age);
        //   }

        //    public Student(string adds) : this(true)
        //    {
        //        Console.WriteLine("address:" + adds);
        //    }


        //   public Student()
        //   {
        //      Console.WriteLine("Empaty");
        //    }

        //   public Student(bool isMarried)
        ////    {
        //       Console.WriteLine("Married");
        ////    }





        //    public Student(string studentName, int studentAge)
        //    {
        //        name = studentName;
        //        age = studentAge;
        //        Console.WriteLine(name + " " + age);
        //}


        //public string FulLName()
        //{
        //    return name + " " + surname;
        //}

        //public string FullData()
        //{
        //    return name + " " + surname + " " + age;
        //}
        public string GetGroupInfo()
        {
            Teacher teacher = new Teacher();
            teacher.name = "Cavid";

            return $"Teacher name: {teacher.GetTeacherName()} Student name: {name}";
        }




    }

}

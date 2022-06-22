using System;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[8];
            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 55;


            //int[] nums = {1, 4, 3, 5, 6, 10, 8, 11, 33, 24 };
            //Array.Sort(nums);
            //foreach(var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //int[, ,] arr = new int[2,2,3]{

            //    { {1, 2, 3}, {3, 4, 5 } },
            //   { {2, 3, 9}, {5, 6, 11} },

            //};
            //Console.WriteLine(arr.Rank);

            // Array.Resize(ref numbers, 20);
            //// numbers[10] = 40;

            // foreach (var item in numbers)
            // {
            //     Console.WriteLine(item);
            // }

            //string name1 = "Sadiq";
            //string surname1 = "Nahmetov";
            //int age1 = 22;

            //string nema2 = "Ramil";
            //string surname2 = "Binnetov";
            //int age2 = 20;

            //string name3 = "Azer";
            //string surname3 = "Humbetov";
            //int age3 = 21;

            //Console.WriteLine(name1+ " "+surname1);

            //var objNameSurNameAge = new
            //{
            //    name = "Sadiq",
            //    surname = "Nahmetov",
            //    age = 22
            //};
            //var objNameSurNameAgee = new
            //{
            //    name = "Ramil",
            //    surname = "Binnetov",
            //    age = 20
            //};            ////Console.WriteLine(obj1.name + " " + obj1.surname);
            //Console.WriteLine($"{obj2.name} {obj2.surname} Age: {obj2.age}");



            //Student st1 = new Student(77,"Hovsan");
            //st1.name = "Sadiq";
            //st1.surname = "Nahmetov";
            //st1.age = 22;

            //Student st2 = new Student();
            //st2.name = "Ramil";
            //st2.surname = "Binnetov";
            //st2.age = 20;

            //Console.WriteLine(st1.FulLName( "Hovsan"));
            //Console.WriteLine(st2.FullData());

            //Student st3 = new Student
            //{
            //    name = "Cavid",
            //    surname = "Bashirov",
            //    age = 28
            //};

            Student student = new Student();

            student.name = "Aziz";

            var result = student.GetGroupInfo();


            Console.WriteLine(result);

        }


    }
}


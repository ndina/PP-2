﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Student
    {
        public string name;
        public string sname;
        public double gpa;

        public Student()
        {
            name = Console.ReadLine();
            sname = Console.ReadLine();
            gpa = 4;
        }
        public override string ToString()
        {
            return name + " " + sname + " " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s);
            Console.ReadKey();


        }
    }
}

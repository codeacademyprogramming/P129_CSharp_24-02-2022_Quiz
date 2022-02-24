using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork1.Models
{
    class Student
    {
        private string _fullName;
        public string FullName 
        {
            get => _fullName;
            set
            {
                while (!CheckFullname(value))
                {
                    Console.WriteLine("Duzgun Ad Soyad Daxil Et:");
                    value = Console.ReadLine();
                }
                _fullName = value;
            } 
        }
        private string _groupNo;
        public string GroupNo 
        {
            get => _groupNo;
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Duzgun Qrup Nomresi Daxil Et");
                    value = Console.ReadLine();
                }
                _groupNo = value;
            }
        }
        public int Age { get; set; }

        public Student(string fullname, string groupNo, int age)
        {
            FullName = fullname;
            GroupNo = groupNo;
            Age = age;
        }

        public static bool CheckGroupNo(string groupNo)
        {

            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]) && int.TryParse(groupNo.Substring(1), out int num))
                return true;
            return false;
        }

        public static bool CheckFullname(string fullName)
        {
            return fullName.Split(' ').Length >= 2;
        }
    }
}

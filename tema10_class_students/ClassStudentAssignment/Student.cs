using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudentAssignment
{
    public class Student
    {
        private int _age;
        private string _name;
        public const int min_age = 18;
        public const int max_age = 99;

        public string Name
        {
            get { return _name; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = (value >= min_age) ? ((value <= max_age) ? value: 0) : 0; }
        }

        public int? Mark { get; set; }

        public string Info
        {
            get { return $"Person {_name} is {_age} years old."; }
        }

        public Student (int age, string name)
        {
            this._age = (age >= min_age) ? ((age <= max_age) ? age : 0) : 0;
            this._name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp
{
    class Student : User
    {
        int gradeNum;

        public Student(int _gradeNum, string _fName, string _lName, int _yearOfBirth, string _email) :base(_fName, _lName, _yearOfBirth, _email)
        {
            this.gradeNum = _gradeNum;
        }

        public int GradeNum
        {
            get { return this.gradeNum; }
            set { this.gradeNum = value; }
        }

        public override void PrintingInfo()
        {
            Console.WriteLine($"{this.Fname} {this.LName} , {this.YearOfBirth} : {this.Email} grade:{this.GradeNum}");
        }
    }
}

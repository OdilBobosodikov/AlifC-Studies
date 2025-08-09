using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task9.Task9._2
{
    public class Student : Person
    {
        private string _program;
        private int _year;
        private double _fee;

        public string GetProgram() => _program;

        public void SetProgram(string program) => _program = program;

        public int GetYear() => _year;

        public void SetYear(int year) => _year = year;

        public double GetFee() => _fee;

        public void SetFee(double fee)
        {
            _fee = fee;
        }

        public Student(string name, string address, string program, int year, double fee)
            : base(name, address)
        {
            _program = program;
            _year = year;
            _fee = fee;
        }

        public override string ToString()
        {
            return $"Student[{base.ToString()}, program={_program},year={_year},fee={_fee}]";
        }
    }
}

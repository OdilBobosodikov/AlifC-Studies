using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task9.Task9._2
{
    public class Staff : Person
    {
        private string _school;
        private double _pay;

        public string GetSchool() => _school;

        public void SetSchool(string school) => _school = school;

        public double GetPay() => _pay;

        public void SetPay(double pay) => _pay = pay;

        public Staff(string name, string address, string school, double pay)
            : base(name, address)
        {
            _school = school;
            _pay = pay;
        }

        public override string ToString()
        {
            return $"Staff[{base.ToString()}, school={_school},pay={_pay}]";
        }
    }
}

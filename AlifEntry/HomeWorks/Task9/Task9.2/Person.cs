using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task9.Task9._2
{
    public class Person
    {
        private string _name;
        private string _address;

        public Person(string name, string address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetAddress()
        {
            return _address;
        }

        public void SetAddress(string address)
        {
            _address = address;
        }

        public override string ToString()
        {
            return $"Person[name={_name},address={_address}]";
        }
    }
}

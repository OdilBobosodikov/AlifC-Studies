using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.Polymorghism
{
    internal class Square : Shape
    {
        private double _side;
        public double GetSide() => _side;
        public void SetSide(double side) => _side = side;

        public Square() { }

        public Square(double side)
        {
            _side = side;
        }

        public Square(double side, string color, bool filed) : base(color, filed) 
        {
            _side = side;
        } 


        public override double GetArea()
        {
            return _side * _side;
        }

        public override double GetPerimeter()
        {
            return _side * 4;
        }

        public override string ToString()
        {
            return $"Side: {_side}, " + base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.Polymorghism
{
    internal class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public double GetWidth() => _width;
        public double SetWidth(double width) => _width = width;
        
        public double GetHeight() => _height;
        public double SetHeight(double height) => _height = height;

        public Rectangle(double width, double height, string color, bool filled) : base(color, filled) 
        {
            _width = width;
            _height = height;
        }

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public Rectangle()
        {
            
        }

        public override double GetArea()
        {
            return _height * _width;
        }

        public override double GetPerimeter()
        {
            return (_height + _width) * 2;
        }

        public override string ToString()
        {
            return $"Height: {_height}, Width: {_width}, " + base.ToString();
        }
    }
}

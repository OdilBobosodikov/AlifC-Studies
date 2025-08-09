using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task9.Task9._1
{
    internal class Circle
    {
        private double _radius = 1;
        private string _color;

        public void SetRadius(double radius) => _radius = radius;
        public double GetRadius() => _radius;
        public string GetColor() => _color;
        public void GetColor(string color) => _color = color;

        public Circle()
        {
            _color = "red";
        }
        public Circle(double radius)
        {
            _radius = radius;
            _color = "red";
        }

        public Circle(double radius, string color)
        {
            _radius = radius;
            _color = color;
        }

        public double GetArea() 
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override string ToString()
        {
            return $"Circle[radius={_radius},color={_color}]";
        }
    }
}

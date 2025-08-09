using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task9.Task9._1
{
    internal class Cylinder : Circle
    {
        private double _height = 0;

        public void SetHeight(double height) => _height = height;
        public double GetHeight() => _height;

        public Cylinder() : base() { }

        public Cylinder(double radius) : base (radius) { }

        public Cylinder(double radius, double height) : base(radius)
        {
            _height = height;
        }

        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            _height = height;
        }

        public double GetVolume() 
        {
            return Math.PI * Math.Pow(GetRadius(), 2) * _height;
        }
    }
}

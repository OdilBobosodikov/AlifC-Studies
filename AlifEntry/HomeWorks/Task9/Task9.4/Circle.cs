using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.Polymorghism
{
    internal class Circle : Shape
    {
        private double _radius;

        public void SetRadius(double radius) => _radius = radius;
        public double GetRadius() => _radius;

        public Circle() { }

        public Circle(double radius) 
        {
            _radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled) 
        {
            _radius = radius;
        }


        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public override string ToString()
        {
            return $"Radius: {_radius}, " + base.ToString();
        }
    }
}

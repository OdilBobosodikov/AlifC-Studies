using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.Polymorghism
{
    internal abstract class Shape
    {
        private string _color;
        private bool _filled;

        public Shape()
        {
            _color = "red";
            _filled = true;
        }

        public Shape(string color, bool filed)
        {
            _color = color;
            _filled = filed;
        }

        public string GetColor() => _color;

        public void SetColor(string color) => _color = color;

        public bool IsFilled() => _filled;

        public void SetFilled(bool filed) => _filled = filed;

        public abstract double GetArea();
        public abstract double GetPerimeter();
        
        public override string ToString()
        {
            return $"Color: {_color}, IsFilled: {_filled}";
        }

    }
}

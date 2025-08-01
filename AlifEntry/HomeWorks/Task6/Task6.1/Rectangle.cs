using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task6.Task6._1
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        private string _color = "Unknown";

        public int Width
        {
            get => _width;
            set
            {
                if (value > 0) 
                {
                    _width = value;
                }
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }

        public string Color
        {
            get => _color;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _color = value;
                }
            }
        }

        public Rectangle(int height, int width, string color)
        {
            Height = height;
            Width = width;
            Color = color;
        }

        public int GetArea()
        {
            return Width * Height;
        }

        public int GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}

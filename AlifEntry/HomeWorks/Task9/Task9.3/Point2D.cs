using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task9.Task9._3
{
    public class Point2D
    {
        private float _x = 0;
        private float _y = 0;

        public Point2D(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public Point2D() { }

        public float GetX() => _x;
        public void SetX(float x) => _x = x;

        public float GetY() => _y;
        public void SetY(float y) => _y = y;

        public void SetXY(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public float[] GetXY() => new float[] { _x, _y };

        public override string ToString() => $"({_x},{_y})";
    }
}

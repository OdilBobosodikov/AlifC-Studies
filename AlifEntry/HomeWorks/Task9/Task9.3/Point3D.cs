using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task9.Task9._3
{
    public class Point3D : Point2D
    {
        private float _z = 0;
        public Point3D(float x, float y, float z) : base(x, y)
        {
            _z = z;
        }

        public Point3D() { }

        public float GetZ() => _z;
        public void SetZ(float z) => _z = z;

        public void SetXYZ(float x, float y, float z)
        {
            SetXY(x, y);
            _z = z;
        }

        public float[] GetXYZ() => new float[] { GetX(), GetY(), _z };

        public override string ToString() => $"({GetX()},{GetY()},{_z})";
    }
}

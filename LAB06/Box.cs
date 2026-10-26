using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB06
{
    internal class Box
    {
        private int lenght;
        private int width;
        private int depth;

        public int Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Длина должна быть больше 0");
                }
                    lenght = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ширина должна быть больше 0");
                }
                width = value;
            }
        }
        public int Depth
        {
            get
            {
                return depth;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Глубина должна быть больше 0");
                }
                depth = value;
            }
        }
        public Box(int lenght, int width, int depth)
        {
            Lenght = lenght;
            Width = width;
            Depth = depth;
        }
        public Box(int side)
            : this(side, side, side)
        { }
        public static Box operator +(Box a, Box b)
        {
            return new(
            Math.Max(a.Lenght, b.Lenght),
            Math.Max(a.Width, b.Width),
            Math.Max(a.Depth, b.Depth)
            );
        }
        public static Box operator -(Box a, Box b)
        {
            return new(
            Math.Min(a.Lenght, b.Lenght),
            Math.Min(a.Width, b.Width),
            Math.Min(a.Depth, b.Depth)
            );
        }
        public override string ToString()
        {
            return $"Box [{Lenght}, {Width}, {Depth}]";
        }
        public static bool operator ==(Box a, Box b)
        {
            if(a.Lenght * a.Width * a.Depth == b.Lenght * b.Width * b.Depth)
            {
                return true ;
            }
            return false ;
        }
        public static bool operator !=(Box a, Box b) 
        {
            return !(a == b);
        }
    }
}

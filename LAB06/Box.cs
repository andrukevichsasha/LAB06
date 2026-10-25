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
                if(value > 0)
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
                if (value > 0)
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
                if (value > 0)
                    depth = value;
            }
        }
        public Box(int lenght, int width, int depth)
        {
            Lenght = lenght;
            Width = width;
            Depth = depth;
        }
    }
}

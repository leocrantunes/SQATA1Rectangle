using System;
using System.Collections.Generic;
using System.Text;

namespace SQATA1Rectangle
{
    public class Rectangle
    {
        private const int MIN_LENGTH = 1;
        private const int MIN_WIDTH = 1;

        private int length;
        private int width;

        public Rectangle()
        {
            length = MIN_LENGTH;
            width = MIN_WIDTH;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }

        public void SetLength(int length) 
        {
            if (length < MIN_LENGTH)
            {
                throw new ArgumentOutOfRangeException($"Value {length} is less than {MIN_LENGTH}");
            }

            this.length = length;
        }
        
        public int GetWidth()
        {
            return width;
        }

        public void SetWidth(int width) 
        {
            if (width < MIN_WIDTH)
            { 
                throw new ArgumentOutOfRangeException($"Value {width} is less than {MIN_WIDTH}"); 
            }

            this.width = width; 
        }
        
        public int GetPerimeter() 
        {
            return 2 * (length + width);
        }
        
        public int GetArea() 
        {
            return length * width;
        }
    }
}

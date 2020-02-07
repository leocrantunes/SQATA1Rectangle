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
            ValidateLength(length);
            ValidateWidth(width);

            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length) 
        {
            ValidateLength(length);

            this.length = length;

            return this.length;
        }
        
        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width) 
        {
            ValidateWidth(width);

            this.width = width;

            return this.width;
        }
        
        public int GetPerimeter() 
        {
            return 2 * (length + width);
        }
        
        public int GetArea() 
        {
            return length * width;
        }

        private void ValidateLength(int length)
        {
            if (length < MIN_LENGTH)
            {
                throw new ArgumentOutOfRangeException($"Length value '{length}' is less than '{MIN_LENGTH}'");
            }
        }

        private void ValidateWidth(int width)
        {
            if (width < MIN_WIDTH)
            {
                throw new ArgumentOutOfRangeException($"Width value '{width}' is less than '{MIN_WIDTH}'");
            }
        }
    }
}

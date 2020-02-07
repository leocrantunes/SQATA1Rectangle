using System;
using System.Collections.Generic;
using System.Text;

namespace SQATA1Rectangle
{
    /// <summary>
    /// Class that represents a rectangular geometric figure
    /// </summary>
    public class Rectangle
    {
        // constants
        private const int MIN_LENGTH = 1;
        private const int MIN_WIDTH = 1;

        // fields
        private int length;
        private int width;

        /// <summary>
        /// Default constructor
        /// Initializes length and width with the minimum value
        /// </summary>
        public Rectangle()
        {
            length = MIN_LENGTH;
            width = MIN_WIDTH;
        }

        /// <summary>
        /// Non-default constructor
        /// Initializes length and width as defined for the user
        /// Contains validation in case of invalid values are informed
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(int length, int width)
        {
            ValidateLength(length);
            ValidateWidth(width);

            this.length = length;
            this.width = width;
        }

        /// <summary>
        /// Returns the current length of the rectangle
        /// </summary>
        /// <returns>current length</returns>
        public int GetLength()
        {
            return length;
        }

        /// <summary>
        /// Sets a new value to the length of the rectangle
        /// Contains validation in case of invalid values are informed
        /// </summary>
        /// <param name="length">new length</param>
        /// <returns>updated length</returns>
        public int SetLength(int length) 
        {
            ValidateLength(length);

            this.length = length;

            return this.length;
        }

        /// <summary>
        /// Returns the current width of the rectangle
        /// </summary>
        /// <returns>current width</returns>
        public int GetWidth()
        {
            return width;
        }

        /// <summary>
        /// Sets a new value to the width of the rectangle
        /// Contains validation in case of invalid values are informed
        /// </summary>
        /// <param name="width">new width</param>
        /// <returns>updated width</returns>
        public int SetWidth(int width) 
        {
            ValidateWidth(width);

            this.width = width;

            return this.width;
        }
        
        /// <summary>
        /// Calculates the perimiter of the rectangle
        /// </summary>
        /// <returns></returns>
        public int GetPerimeter() 
        {
            return 2 * (length + width);
        }

        /// <summary>
        /// Calculates the area of the rectangle
        /// </summary>
        /// <returns></returns>
        public int GetArea() 
        {
            return length * width;
        }

        /// <summary>
        /// Auxiliary method to validate the length of the rectangle
        /// </summary>
        /// <param name="length"></param>
        private void ValidateLength(int length)
        {
            if (length < MIN_LENGTH)
            {
                throw new ArgumentOutOfRangeException($"Length value '{length}' is less than '{MIN_LENGTH}'");
            }
        }

        /// <summary>
        /// Auxiliary method to validate the width of the rectangle
        /// </summary>
        /// <param name="width"></param>
        private void ValidateWidth(int width)
        {
            if (width < MIN_WIDTH)
            {
                throw new ArgumentOutOfRangeException($"Width value '{width}' is less than '{MIN_WIDTH}'");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private int length;
        private int width;

        // Default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // Non-default constructor
        public Rectangle(int initialLength, int initialWidth)
        {
            length = initialLength;
            width = initialWidth;
        }

        // Getter and setter methods
        public int GetLength()
        {
            return length;
        }

        public void SetLength(int newLength)
        {

            if (IsValid(newLength))
            {
                length = newLength;
            }
            else
            {
                // Handle invalid length (throw exception, log, etc.)
                throw new ArgumentException("Length must be greater than 0.");
            }

        }



        public int GetWidth()
        {
            return width;
        }

        public void SetWidth(int newWidth)
        {
            if (IsValid(newWidth))
            {
                width = newWidth;
            }
            else
            {
                // Handle invalid length (throw exception, log, etc.)
                throw new ArgumentException("Width must be greater than 0.");
            }
        }

        // Methods for calculating perimeter and area
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }

        private bool IsValid(int value)
        {
            return value > 0;
        }
    }
}

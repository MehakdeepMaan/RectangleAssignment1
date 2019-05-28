using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
  public class Rectangle
    {   
        // declare the two public variable length and width
        public int length;
        public int width;
        // rectangle constuctor with two integer parameters
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;

        }
        // default constructor of class rectangle
        public Rectangle()
        {
        }

        //1   Using Getlength method for getting the length of rectangle
        public double GetLength()
        {
            return length;
        }
        //2 using Setlength method for setting the length of rectangle
        public void SetLength(int length)
        {
            this.length = length;
           
        }
        //3 using Getwidth method for getting the width of ractangle
        public double GetWidth()
        {
            return width;

        }
        //4  using Setwidth method for setting the width of rectangle
        public void  SetWidth(int width)
        {
            this.width = width;
           // return this.width;
        }
        //5 using Getperimeter method for calculating the perimeter of rectangle
        public double GetPerimeter()
        {
            return ((width * 2) + (length * 2));
        }
        //6 using Getarea method for calculating the area of rectangle by multiply length with width
        public double GetArea()
        {
            return (length * width);
        }

      
    }
    
}

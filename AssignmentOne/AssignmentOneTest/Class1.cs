using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentOne;
using NUnit.Framework;
using AssignmentOneTest;


namespace AssignmentOneTest
{
    [TestFixture]
    public class AssignmentOneTest
    {
        //task 1 GetLength
        [Test]
        public void GetLength_input5_expectedLengthEquals5()
        {
            //Arrange
            int l = 5;
            int w = 6;
            Rectangle rectangle = new Rectangle(l, w);
            // Act
            double length = rectangle.GetLength();

            // Assert
            Assert.AreEqual(l, length);
        }
        //task 2 SetLength
        [Test]
        public void SetLength_input4_expectedlengthEquals4()
        {
            // Arrange
            int l = 4;
            int w = 6;
            Rectangle rectangle = new Rectangle(l, w);
            //Act 
            rectangle.SetLength(l);

            // Assert
            Assert.AreEqual(l, rectangle.length);
        }
        //task 3 GetWidth
        [Test]
        public void GetWidth_input7_expectedWidthEquals7()
        {
            // Arrange
            int l = 3;
            int w = 7;
            Rectangle rectangle = new Rectangle(l, w);
            //Act
            double width = rectangle.GetWidth();
            // Assert
            Assert.AreEqual(w, width);

        }
        // task4 SetWidth
        [Test]
        public void SetWidth_input2_expectedWidthEquals2()
        {
            // Arrange
            int l = 4;
            int w = 2;
            Rectangle rectangle = new Rectangle(l,w);
            // Act 
            rectangle.SetWidth(w);
            //Assert
            Assert.AreEqual(w, rectangle.width);

        }
        //Task 5 GetPerimeter
        [Test]
        public void GetPerimeter_inputLength4AndInputWidth4_expectedresult16()
        {
            // Arrange
            int l = 4;
            int w = 4;
            Rectangle rectangle = new Rectangle(l, w);
            //Act
            int result = ((l * 2) + (w * 2));
            double actualReult = rectangle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, actualReult);
            
        }
        //Task6 GetArea 
        [Test]
        public void GetArea_inputLength2AndinputWidth2_expectedResult4()
        {
            // Arrange
            int l = 2;
            int w = 2;
            Rectangle rectangle = new Rectangle(l, w);
            // Act
            int result = l * w;
            double actualResult = rectangle.GetArea();
            //Assert
            Assert.AreEqual(result, actualResult);


        }
    }
}

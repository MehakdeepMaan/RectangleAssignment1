using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentOne
{
    class Program
    {
      
        
        public static int ValidateMenuSelection()
        {
            // declare  a string variable and initialising a boolen variable
            string userInput="";
            bool validMenuSelect = false;
            // using while for selecting an option from displying optons
            while(validMenuSelect ==false)
            {
                Console.WriteLine("1 =Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle length");
                Console.WriteLine("3 = Get Rectangle width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit");

                Console.WriteLine("Please selectan otion, by entering a number");
                userInput = Console.ReadLine();

                 if (userInput !="1" &&
                    userInput !="2" &&
                    userInput !="3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput !="7" )
                {
                    Console.WriteLine("That is not a valid menu option, please try again ");
                }else
                {
                    validMenuSelect = true;
                }

            }
            Console.WriteLine();
            return int.Parse(userInput);
        }
        // using method with parameters
        public static int ValidateUserInput(string rectside)
        {
            int number = 1;
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {rectside} of your rectangle: ");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);
                if (result == false)
                {
                    Console.WriteLine("That is not a valid input, please try again ");

                }
                else if (number < 0)
                {
                    Console.WriteLine("Number cannot be less than 0 , please try again ");

                }else
                {
                    isValid = true;
                    Console.WriteLine($"the {rectside} of your rectangle is now {number}\n");
                }
                
            }
            return number;
        }
        static void Main(string[] args)
        {
            //creating an object of recatngle class
            Rectangle r = new Rectangle();
            bool validRectangleSelect = false;
            string rectangleSelction;
            int selection;
            //using while for checking that is user selecting the correct option or not
            while (validRectangleSelect == false)
            {
                Console.WriteLine("2 =  Please enter 2 to provide your own numbers\n");
             
                rectangleSelction = Console.ReadLine();
                Console.WriteLine(); 
                // if enter number is 2 then it will ask further for length and width of rectangle
                 if (int.Parse(rectangleSelction)==2)
                {
                    validRectangleSelect = true;

                    int  length;
                    int width;
                    length = ValidateUserInput("length");
                    width = ValidateUserInput("width");
                    // displying the length and the width of rectangle
                    Console.WriteLine($"Your length and width are {length} and {width}.\n");
                    Rectangle customRectangle = new Rectangle(length, width);
                    r = customRectangle;

                }


            }
            selection = ValidateMenuSelection();
            
            while (selection !=9)
            {
                int result =0;
                //using switch  for performing the unique task with each case
                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"length is: {r.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("length");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"width is: {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("setwidth");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The result of {r.GetLength() *2} + {r.GetWidth() *2} is: {r.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The result of {r.GetLength()} * {r.GetWidth()} is: {r.GetArea()}\n");
                        break;
                    case 7:
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;

                }

                selection = ValidateMenuSelection();
            }
        }
    }
}

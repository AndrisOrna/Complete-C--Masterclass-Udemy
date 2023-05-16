using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseCSharp
{
    class Operators
    {
        static void Main(string[] args)// sim + double tab creates Main method
        {
            int number1 = -5;
            int number2 = 3;
            int number3;
            //return 0;

            // unary operators
            Console.WriteLine("########## Unary operators #############");
            number3 = -number1;
            Console.WriteLine("number3 is {0}", number3);
            Console.WriteLine();


            // true or false
            Console.WriteLine("########## True/ False #############");
            bool isSunny = true;
            Console.WriteLine("is it sunny???? {0}", isSunny);// !  true
            Console.WriteLine("is it sunny???? {0}", !isSunny);//   '!' on the front turns to false
            Console.WriteLine();

            //increment operators
            Console.WriteLine("########## Increment operators #############");
            int num = 0;
            num++;
            Console.WriteLine("Number incremented by one {0}", num);
            Console.WriteLine("Number incremented by one {0}", num++);
            // pre increment
            Console.WriteLine("Number pre incremented by one {0}", ++num);
            Console.WriteLine();
            
            // decrement operators
            Console.WriteLine("########## Decrement operators #############");
            num--;
            Console.WriteLine("Number decremented by one {0}", num);
            Console.WriteLine("Number decremented by one {0}", num--);
            // pre decrement
            Console.WriteLine("Number pre decremented by one {0}", --num);
            Console.WriteLine();


            Console.WriteLine("########## PLUS operators #############");
            int result;
            result = number1+ number2;
            Console.WriteLine("Sum of number1 " + number1 + " and number2 " + number2 + " is: {0} ", result);
            Console.WriteLine();

            //int result;
            Console.WriteLine("########## MINUS operators #############");
            result = number1 - number2;
            Console.WriteLine("number1 " + number1 + " minus number2 " + number2 + " is: {0} ", result);
            Console.WriteLine();

            Console.WriteLine("########## DEVIDE operators #############");
            Console.WriteLine("Number1 is:" + number1);
            Console.WriteLine("Number2 is:" + number2);
            result = number1 / number2;
            Console.WriteLine("Devide " + number1 + " with number2 " + number2 + " is: {0} ", result);
            Console.WriteLine();
            
            Console.WriteLine("########## MULTIPLY operators #############");
            Console.WriteLine("Number1 is:" + number1);
            Console.WriteLine("Number2 is:" + number2);
            result = number1 * number2;
            Console.WriteLine("Multiply " + number1 + " with number2 " + number2 + " is: {0} ", result);
            Console.WriteLine();
            
            
            Console.WriteLine("########## MODULAR (returns reminder) operators #############");
            Console.WriteLine("Number1 is:" + number1);
            Console.WriteLine("Number2 is:" + number2);
            result = number1 % number2;
            Console.WriteLine("DEVIDING " + number1 + " with number2 " + number2 + " reminder is: {0} ", result);
            Console.WriteLine();

            // RELATIONAL AND TYPE OPERATORS
            Console.WriteLine("########## RELATIONAL AND TYPE OPERATORS operators #############");
            Console.WriteLine("Number1 is:" + number1);
            Console.WriteLine("Number2 is:" + number2);
            bool isLess;
            bool isGreater;

            isLess = number1 < number2;
            isGreater = number1 > number2;
            Console.WriteLine("Checking if " + number1 + " is less then number2 " + number2 + " the answer is: {0} ", isLess);
            Console.WriteLine("Checking if " + number1 + " is greater then number2 " + number2 + " the answer is: {0} ", isGreater);

            // equal operator
            bool isEqual;
            isEqual= number1 == number2;
            Console.WriteLine("Checking if " + number1 + " is equal with number2 using ==" + number2 + " the answer is: {0} ", isEqual);
            Console.WriteLine("Is number1 equal number2 using '==' , the answer is:  {0} ", isEqual);
            isEqual= number1 != number2;
            Console.WriteLine("Is number1 equal number2 using '!=' , the answer is:  {0} ", isEqual);
            Console.WriteLine();

            // CONDITIONAL OPERATORS
            Console.WriteLine("########## CONDITIONAL OPERATORS #############");

            bool isLessAndSunny;
            isLessAndSunny = isLess && isSunny;
            Console.WriteLine("Comparing two bools");
            Console.WriteLine("isLess: " + isLess);
            Console.WriteLine("isSunny: " + isSunny);
            Console.WriteLine("Comparing less and sunny, the answer is: {0}", isLessAndSunny);
            Console.WriteLine("'True' and 'True' returns TRUE");
            Console.WriteLine();
            // condition1 OR condition2, both needs to be true to return TRUE 
            isLessAndSunny = isLess || isSunny;
            Console.WriteLine("isLess: " + isLess);
            Console.WriteLine("isSunny: " + isSunny);
            Console.WriteLine("Result of isLess || isSunny {0}", isLessAndSunny);









            Console.ReadKey();
        }
    }
}

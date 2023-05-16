//using System;

//namespace udemycoursecsharp
//{
//    class TryAndCatch
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number 1 ");
//            string input1 = Console.ReadLine();
//            // try and catch type try and double tab
//            try
//            {
//                int number1 = int.Parse(input1);// Ctrl + F (formatting the line)

//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Format exception, please enter the correct type of input");
//                //throw;
//            }
//            catch (OverflowException)
//            {
//                Console.WriteLine("OverflowException, to long or to short215");
//                //throw;
//            }
            
//            catch(ArgumentNullException)  // can be also OverflowException
//            {
//                Console.WriteLine("ArgumentNullException Exception");
//            }
//            finally 
//            {
//                Console.WriteLine("It is called anyways, for example internet connection failed");
//            }
            
//            Console.ReadKey();
//            // #region
//            //Console.WriteLine(); // cw and double tab
//            //AddingInput();
//            //string input = Console.ReadLine();// string stored as input
//            //Console.WriteLine(AddingInput());// returns this method
//            //Console.Read();
//            // #endregion
//        }
//// #region AddingInputs method
//        //public static int AddingInput()
//        //{
//        //    Console.WriteLine("Enter number 1 ");
//        //    //Console.ReadKey();
//        //    string input1 = Console.ReadLine();// string stored as input
//        //    Console.WriteLine("Enter number 2 ");
//        //    string input2 = Console.ReadLine();// string stored as input

//        //    // converting string to int
//        //    int number1 = int.Parse(input1);
//        //    int number2 = int.Parse(input2);
//        //    int result = number1 + number2;
//        //    Console.WriteLine("Sum of those numbers are: " + result);
//        //    Console.Read();
//        //    return result;
//        //}
//        //public static int add(int num1, int num2)
//        //{
//        //    return num1 + num2;
//        //}

//// #endregion
//    }
//}

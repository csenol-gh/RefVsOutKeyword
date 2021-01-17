using System;

namespace RefVsOutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            int result1 = 0;
            int number3;
            int number4 = 20;
            int result2 = 0;

            Console.WriteLine("number1: " + number1);
            result1 = AddWithRefKeyword(ref number1, number2);
            Console.WriteLine("number1: " + number1 + " result: " + result1);

            //Console.WriteLine("number3: " + number3);
            result2 = AddWithOutKeyword(out number3, number4);
            Console.WriteLine("number3: " + number3 + " result: " + result2);

        }

        /*This method takes firstNumber and secondNumber, adds them up,
        changes firstNumber and returns their sum. firstNumber needs to
        be assigned before calling the method since method signature
        includes ref keyword. Otherwise, there will be error.
        This keyword takes the address of firstNumber as parameter rather than
        its value so that when the parameter is changed inside the method,
        the value at that address will be changed.*/
        static int AddWithRefKeyword(ref int firstNumber, int secondNumber)
        {
            firstNumber = 999;
            int result = firstNumber + secondNumber;
            return result;
        }

        /*This method takes firstNumber and secondNumber, adds them up,
        changes firstNumber and returns their sum. firstNumber does NOT
        need to be assigned before calling the method since method signature
        includes out keyword.
        This keyword takes the address of firstNumber as parameter rather than
        its value so that when the parameter is changed inside the method,
        the value at that address will be changed.*/
        static int AddWithOutKeyword(out int firstNumber, int secondNumber)
        {
            firstNumber = 999;
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}

using System;

namespace FumctionAndArrayHW
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Console.WriteLine("enter a number");

            //bool isNumber = int.TryParse(Console.ReadLine(), out int number);

            //int number1;

            //if (int.TryParse(Console.ReadLine(), out number1))
            //{
            //    Console.WriteLine("correct");
            //}
            //else
            //{
            //    Console.WriteLine("not correct");
            //}
            Pt1();
            //Pt2();
            //Pt3();


        }
        static void Pt1()
        { 
            
            //pt 1
            Console.WriteLine("------------------pt1 -----------------");
            int result = CheckIsNumberOrNot();
            Console.WriteLine($"is the number polindrom ? {CheckIsPolidrom(result)}");
            Console.WriteLine("---------------------------------------");
            //////////////////////////////////////////////////////////////////////
        }
        static int CheckIsNumberOrNot()
        {
            Console.WriteLine("enter a number ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int result);
            while (!isNumber)
            {
                Console.WriteLine("wrong number! enter a number ");
                isNumber = int.TryParse(Console.ReadLine(), out result);
            }

            return result;
        }
        static bool CheckIsPolidrom(int result)
        {

            int sum = 0;
            int temp = result;
            int number = 0;
            while (result > 0)
            {
                number = (result % 10);
                sum = (sum * 10) + number;
                result /= 10;
            }
            return temp == sum;
        }
        static bool CheckIsPolidromWithString(int result)
        {
            int temp = result;
            string number = "";
            while (result > 0)
            {
                number += (result % 10).ToString();
                result /= 10;
            }
            return temp.ToString() == number.ToString();
        }
        static void Pt2()
        {
            //pt2
            Console.WriteLine("------------------pt2 -----------------");
            PrintNumberName(CheckIsNumberOrNot());
            Console.WriteLine("---------------------------------------");
            //////////////////////////////////////////////////////////////////////
        }
        static void PrintNumberName(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                default:
                    Console.WriteLine("number not in range");
                    break;
            }

        }
        static void Pt3()
        {
            //pt2
            Console.WriteLine("------------------pt3 -----------------");
            PrintNumberName(CheckIsNumberOrNot());
            Console.WriteLine("---------------------------------------");
            //////////////////////////////////////////////////////////////////////
        }

    }
}

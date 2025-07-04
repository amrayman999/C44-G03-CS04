using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Console.Write("Enter a number: ");
            //float number = float.Parse(Console.ReadLine());
            //if(number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region question 2
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //if(number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else if (number == 0)
            //{
            //    Console.WriteLine("Zero");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}
            #endregion

            #region Question 3
            //int[] numbers = new int[3];
            //Console.Write("Enter first number: ");
            //numbers[0] = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //numbers[1] = int.Parse(Console.ReadLine());
            //Console.Write("Enter third number: ");
            //numbers[2] = int.Parse(Console.ReadLine());
            //int maxNumber = -999;
            //int minNumber = 999;
            //foreach (int number in numbers)
            //{
            //    if (number > maxNumber)
            //    {
            //        maxNumber = number;
            //    }
            //    if (number < minNumber)
            //    {
            //        minNumber = number;
            //    }
            //}
            //Console.WriteLine($"Maximum element is: {maxNumber}");
            //Console.WriteLine($"Minimum element is: {minNumber}");
            #endregion

            #region Question 4
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            #endregion

            #region Question 5
            //Console.Write("Enter a character: ");
            //char character = char.Parse(Console.ReadLine());
            //string vowels = "aeiouAEIOU";
            //if (vowels.Contains(character))
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion

            #region Question 6
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= number; i++)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();
            #endregion

            #region Question 7
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //for(int i = 1; i<= 12; i++)
            //{
            //    Console.Write($"{number * i} ");
            //}
            #endregion

            #region Question 8
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}
            #endregion

            #region Question 9
            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Enter Power: ");
            //int power = int.Parse(Console.ReadLine());
            //int result = 1;
            //for(int i = 1; i <= power; i++)
            //{
            //    result *= number;
            //}
            //Console.WriteLine($"Result: {result}");

            #endregion

            #region Question 10
            //int[] marks = new int[5];
            //Console.WriteLine("Enter marks for 5 subjects : ");
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    marks[i] = int.Parse(Console.ReadLine());
            //}
            //int total = 0;
            //int average = 0;
            //int percentage = 0;
            //foreach (int mark in marks)
            //{
            //    total += mark;
            //}
            //average = total / marks.Length;
            //percentage = (int)((float)total / (marks.Length * 100) * 100);
            //Console.WriteLine($"Total Marks: {total}");
            //Console.WriteLine($"Average Marks: {average}");
            //Console.WriteLine($"Percentage: {percentage}%");
            #endregion

            #region Question 11
            //Console.Write("Enter month number: ");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine($"Days in Month: {31}");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine($"Days in Month: {30}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Days in Month: {28} or {29} according to leap year or not");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;

            //}
            #endregion

            #region Question 12
            //Console.Write("Enter first number: ");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int secondNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter operation: ");
            //char operation = char.Parse(Console.ReadLine());
            //int result = 0;
            //switch (operation) {
            //    case '+':
            //        result = firstNumber + secondNumber;
            //        break;
            //    case '-':
            //        result = firstNumber - secondNumber;
            //        break;
            //    case '*':
            //        result = firstNumber * secondNumber;
            //        break;
            //    case '/':
            //        if (secondNumber != 0)
            //            result = firstNumber / secondNumber;
            //        else
            //            Console.WriteLine("Cannot divide by zero");
            //        break;
            //    case '%':
            //        result = firstNumber % secondNumber;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation");
            //        break;
            //}
            #endregion

            #region Question 13
            //Console.Write("Enter your string : ");
            //string input = Console.ReadLine();
            //StringBuilder sb = new StringBuilder("");
            //int counter = input.Length - 1;
            //while (counter >= 0)
            //{
            //    sb.Append(input[counter]);
            //    counter--;
            //}
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Question 14
            //Console.Write("Enter your number: "); 
            //int number = int.Parse(Console.ReadLine());
            //int reversedNum = 0;
            //while(number > 0)
            //{
            //    reversedNum = (reversedNum * 10) + (number % 10);
            //    number /= 10;
            //}
            //Console.WriteLine($"Reversed Number: {reversedNum}");
            #endregion

            #region Question 15
            //Console.Write("Enter starting number: ");
            //int startNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter ending number: ");
            //int endNumber = int.Parse(Console.ReadLine());
            //for (int i = startNumber; i <= endNumber; i++)
            //{
            //    bool isPrime = true;
            //    if (i < 2) isPrime = false; // 0 and 1 are not prime numbers
            //    else
            //    {
            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}
            #endregion

            #region Question 16
            Console.Write("Enter first point :");
            Point p1 = new Point();
            Console.Write("Enter second point :");
            Point p2 = new Point();
            Console.Write("Enter third point :");
            Point p3 = new Point();
            float slope1 = (float)(p2.y - p1.y) / (p2.x - p1.x);
            float slope2 = (float)(p3.y - p2.y) / (p3.x - p2.x);

            if (slope1 == slope2)
            {
                Console.WriteLine("Points are on the same straight line");
            }
            else
            {
                Console.WriteLine("Points are not on the same straight line");
            }
            #endregion
        }
    }

    class Point
    {

        public int x;
        public int y;
        public Point()
        {
            Console.Write("Enter x coordinate: ");
            this.x = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate: ");
            this.y = int.Parse(Console.ReadLine());
        }
        public
    }
}

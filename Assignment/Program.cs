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
            int[] marks = new int[5];
            Console.WriteLine("Enter marks for 5 subjects : ");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            int average = 0;
            int percentage = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            average = total / marks.Length;
            percentage = (int)((float)total / (marks.Length * 100) * 100);
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average}");
            Console.WriteLine($"Percentage: {percentage}%");
            #endregion
        }
    }
}

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
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if(number < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Positive");
            }
            #endregion
        }
    }
}

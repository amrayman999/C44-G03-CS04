namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Console.Write("Enter a number: ");
            float number = float.Parse(Console.ReadLine());
            if(number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            #endregion
        }
    }
}

using System.Text;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3();
            //Q4();
            //Q5();

        }
        static void Q1()
        {
            int[] mulTable = { 1, 2, 3,4,5,6,7,8,9,10 };
            for (int i = 1; i <= 5; i++)
            {
                foreach (int num in mulTable)
                {
                    Console.WriteLine($"{i} x {num} = {num * i}");
                }
            }
        }
        static void Q2()
        { 
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder("");
            int counter = input.Length - 1;
            while(counter >= 0)
            {
                sb.Append(input[counter]);
                counter--;
            }
            Console.WriteLine(sb.ToString());
            
        }
        static void Q3()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Console.WriteLine($"Number of Words is: {words.Length}");

        }
        static void Q4()
        {
            StringBuilder inputString = new StringBuilder(Console.ReadLine());
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int numVowels = 0;
            foreach (char c in inputString.ToString().ToLower())
            {
                if (vowels.Contains(c))
                    numVowels++;
            }
            Console.WriteLine($"Number of vowels is : {numVowels}");

        }
        static void Q5()
        {
            string input = Console.ReadLine();
            input = input.Trim();
            input = input.ToUpper();
            input = input.Replace(' ', '_');
            Console.WriteLine(input);

        }
    }
}

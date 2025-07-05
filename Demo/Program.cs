using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Evolution of switch in C#
            // no jump table will be generated for this switch statement
            //object obj = 10.1; // boxing
            #region C# 7.0 [pattern matching - case guards (when)]
            #region Example 01 [pattern matching on types]
            //switch (obj)
            //{
            //    case int value: // unboxing
            //        Console.WriteLine($"Integer");
            //        break;
            //    case decimal value: // unboxing
            //        Console.WriteLine($"Decimal");
            //        break;
            //    case double value: // unboxing
            //        Console.WriteLine($"Double");
            //        break;
            //    default:
            //        Console.WriteLine($"Unknown type");
            //        break;
            //}
            #endregion

            #region Example 02 [Case guards (when)]
            //switch(obj)
            //{
            //    case int value when value < 10:
            //        Console.WriteLine($"Integer less than 10");
            //        break;
            //    case int value when value > 10:
            //        Console.WriteLine($"Integer greater than 10");
            //        break;
            //    case decimal value:
            //        Console.WriteLine($"decimal");
            //        break;
            //    case double value when value > 5.6 && value < 10.7:
            //        Console.WriteLine($"Double between 5.6 and 10.7");
            //        break;
            //    default:
            //        Console.WriteLine($"Unknown type or condition");
            //        break;
            //}
            #endregion

            #region Example 03 [user - defined data types]
            //object obj = 5;
            //obj = new Person()
            //{ 
            //    Id = 1,
            //    Name = "Foo",
            //    Age = 15
            //};

            //switch (obj)
            //{
            //    case int value when value > 10:
            //        Console.WriteLine($"Integer greater than 10");
            //        break;
            //    case string value:
            //        Console.WriteLine($"String");
            //        break;
            //    case Person value when value.Id == 1 && value.Name == "Ahmed":
            //        Console.WriteLine($"Person with Id 1 and Name Ahmed");
            //        break;
            //    default:
            //        Console.WriteLine($"Unknown type or condition");
            //        break;
            //}
            #endregion


            #endregion

            #region C# 8.0 [pattern matching without alias name - switch expressions - property pattern - nullable type]
            #region Example 01 - pattern matching without alias name 
            //object number = 5;
            //switch (number)
            //{
            //    case int when (int)number < 10:
            //        Console.WriteLine($"Integer less than 10");
            //        break;
            //    case int when (int)number > 10:
            //        Console.WriteLine($"Integer greater than 10");
            //        break;
            //    case decimal:
            //        Console.WriteLine($"Decimal");
            //        break;
            //    case double when (double)number > 5.6 && (double)number < 10.7:
            //        Console.WriteLine($"Double between 5.6 and 10.7");
            //        break;

            //}
            #endregion

            #region switch case before switch expression
            //string option  = Console.ReadLine();
            //string message;
            //switch (option)
            //{
            //    case "1":
            //        message = "Option 1 selected";
            //        break;
            //    case "2":
            //        message = "Option 2 selected";
            //        break;
            //    case "3":
            //        message = "Option 3 selected";
            //        break;
            //    default:
            //        message = "Invalid option selected";
            //        break;
            //}
            //Console.WriteLine(message);

            #endregion

            #region Example 02 - switch expression [constant pattern - discard pattern]
            //Console.WriteLine("Select an option (1, 2, 3):");
            //string option = Console.ReadLine();
            //string message;

            //message = option switch
            //{
            //    "1" => "Option 1 selected",
            //    "2" => "Option 2 selected",
            //    "3" => "Option 3 selected",
            //    _ => "Invalid option selected"
            //};
            //Console.WriteLine(message);
            #endregion

            #region Example 03 - switch expression [property pattern]
            //Person person = new Person()
            //{
            //    Id = 1,
            //    Name = "Ali",
            //    Age = 25
            //};

            //string message = person switch
            //{
            //    { Age: 20, Name: "Ahmed" } => "Hello , Ahmed",
            //    { Name: "Omar" } => "Hello , Omar",
            //    _ => "We do not know you"
            //};
            //Console.WriteLine(message);
            #endregion

            #region Example 04 - [nullable type - relational patterns [partially]]
            //int? X = 10;
            //string message = X switch
            //{
            //    null => "X is null",
            //    int number when number > 0 => "positive number",
            //    int number when number < 0 => "negative number",
            //    0 => "zero"
            //};
            //Console.WriteLine(message);
            #endregion

            #endregion

            #region C# 9.0 [switch expression with relational patterns - logical patterns - enhanced property matching]
            #region Example 01 [relational patterns]
            /// Number Less than 10
            /// number between 10 and 20
            /// number greater than 20
            //int X = 20;
            //string message = X switch
            //{
            //    < 10 => "Number less than 10",
            //    >= 10 and <= 20 => "Number between 10 and 20",
            //    > 20 => "Number greater than 20"
            //};
            //Console.WriteLine(message);

            #endregion
            #region Example 02 [logical patterns ( and , or)]
            /// number between 1 and 9
            /// number between 10 and 20
            /// number is zero 
            /// number outside the range

            //int X = 50;
            //string message = X switch
            //{
            //    > 0 and < 10 => "Number between 1 and 9",
            //    >= 10 and <= 20 => "Number between 10 and 20",
            //    0 => "Number is zero",
            //    > 20 or 0 => "Number outside the range"
            //};
            //Console.WriteLine(message);

            #endregion
            #region Example 03 [enhanced property matching]
            /// person is samy and his age is greater than 10
            /// person is omar and his age is between 20 and 24
            /// person's age is between 50 and 60
            /// any one else [sorry but we do not know you]

            //Person person = new Person()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Age = 20
            //};

            //string message = person switch
            //{
            //    { Name: "Samy", Age: > 10 } => "Hello Samy, you are older than 10",
            //    { Name: "Omar", Age: >= 20 and <= 24 } => "Hello Omar",
            //    { Age: >= 50 and <= 60 } => "You are between 50 and 60",
            //    _ => "Sorry but we do not know you"
            //};
            //Console.WriteLine(message);
            #endregion
            #endregion


            #endregion

            #region Looping | Iteration statements

            #region For - Foreach
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(i == 3)
            //    {
            //        continue; // skip the current iteration
            //    }
            //    numbers[i] += 10; // modify the array
            //    Console.WriteLine(numbers[i]);
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            #endregion

            #region While - Do While

            #region do - while
            //int number;
            //bool isParsed;
            //do
            //{
            //    Console.WriteLine("Enter an even number:");
            //    isParsed = int.TryParse(Console.ReadLine(), out  number);
            //} while (number % 2 == 1 || !isParsed);
            //Console.WriteLine($"You entered an even number: {number}");
            #endregion
            #region while
            /// take a number from user and print
            /// a sequence of numbers from entered number to 10
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //if(isParsed)
            //{
            //    while (number <= 10)
            //    {
            //        Console.WriteLine(number);
            //        number++;
            //    }
            //}
            #endregion
            #endregion

            #endregion

            #region Stirng

            #region Example 01
            /// here we declare just a reference from type string "name"
            /// reference "name" is refering to null
            /// CLR will allocate 4 bytes at stach for reference "name"
            ///   0 bytes allocated at heap
            //string name01;
            /// CLR will allocate 10 bytes at heap for the string "Ahmed"
            //name01 = "Ahmed"; //or name = new string("Ahmed");
            //Console.WriteLine(name01.GetHashCode()); 
            /// CLR will search for the string "Ahmed" in the string pool if exists it will
            /// use the existing one otherwise it will create a new one
            //string name02 = "AHmed";
            //Console.WriteLine(name02.GetHashCode()); // same as name01


            //Console.WriteLine(name01.GetHashCode()); // something
            /// here it leaves the old memory location and creates a new one and put 
            /// the new value in it
            //name01 = "Ali";
            //Console.WriteLine(name01.GetHashCode()); // something else
            #endregion

            #region Example 02
            //string name01 = "Amr";
            //string name02 = "Ahmed";

            //Console.WriteLine($"Name01 => {name01}");
            //Console.WriteLine($"hashcode of Name01 => {name01.GetHashCode()}");

            //Console.WriteLine($"Name02 => {name02}");
            //Console.WriteLine($"hashcode of Name02 => {name02.GetHashCode()}");

            //name02 = name01; // here we are copying the reference not the value

            //Console.WriteLine("======= After copying reference from Name01 to Name02 =======");
            //Console.WriteLine($"Name01 => {name01}");
            //Console.WriteLine($"hashcode of Name01 => {name01.GetHashCode()}");

            //Console.WriteLine($"Name02 => {name02}");
            //Console.WriteLine($"hashcode of Name02 => {name02.GetHashCode()}");

            //name01 = "Omar"; // here we are creating a new string and the reference name01 will point to it

            //// after this line name02 will still point to the old string "Amr"
            //Console.WriteLine("======== After changing value of name01 ========");
            //Console.WriteLine($"Name01 => {name01}");
            //Console.WriteLine($"hashcode of Name01 => {name01.GetHashCode()}");

            //Console.WriteLine($"Name02 => {name02}");
            //Console.WriteLine($"hashcode of Name02 => {name02.GetHashCode()}");
            #endregion

            #region Example 03
            //string message = "Hello";
            //Console.WriteLine($"Message => {message}");
            //Console.WriteLine($"hashcode of Message => {message.GetHashCode()}");

            /// it will not change the original string
            /// it will create a new string and assign it to the reference message
            //message += " Route Academy";
            //Console.WriteLine("======== After concatenation ========");
            //Console.WriteLine($"Message => {message}");
            //Console.WriteLine($"hashcode of Message => {message.GetHashCode()}");

            #endregion


            #endregion

            #region String Methods
            //string message = "  Hello Route Academy   ";

            //Console.WriteLine(message.Length); // length of the string
            //Console.WriteLine(message.ToUpper()); // convert to upper case
            //Console.WriteLine(message.ToLower()); // convert to lower case
            //Console.WriteLine(message.Trim()); // remove leading and trailing spaces
            //Console.WriteLine(message.TrimStart()); // remove leading spaces
            //Console.WriteLine(message.TrimEnd()); // remove trailing spaces
            //Console.WriteLine(message.Contains("Route")); // check if the string contains a substring
            //Console.WriteLine(message.IndexOf("Route")); // get the index of the substring
            //Console.WriteLine(message.LastIndexOf("Route")); // get the last index of the substring
            //Console.WriteLine(message.StartsWith("Hello")); // check if the string starts with a substring
            //Console.WriteLine(message.EndsWith("Academy")); // check if the string ends with a substring
            //Console.WriteLine(message.Replace("Route", "Academy")); // replace a substring with another substring
            //Console.WriteLine(message.Split(' ')); // split the string by a character and return an array of strings
            //Console.WriteLine(message.Substring(2, 5)); // get a substring from the string

            #endregion

            #region StringBuilder
            //StringBuilder message = new StringBuilder("Hello");
            //Console.WriteLine($"Message => {message}");
            //Console.WriteLine($"hashcode of Message => {message.GetHashCode()}");

            /// StringBuilder is mutable, it can be modified without creating a new object
            //message.Append(" Route Academy"); // append a string to the StringBuilder
            //Console.WriteLine("======== After concatenation ========");
            //Console.WriteLine($"Message => {message}");
            //Console.WriteLine($"hashcode of Message => {message.GetHashCode()}");
            #endregion

            #region StringBuilder Methods
            //StringBuilder message = new StringBuilder("Hello");

            //message.Append(" Route Academy"); // append a string to the StringBuilder
            //message.AppendLine( " Route"); // append a new line
            //message.Replace("Route", "Academy"); // replace a substring with another substring
            //message.Clear(); // clear the StringBuilder
            //message.Remove(0, 5); // remove a substring from the StringBuilder 
            //message.Insert(0, "Hello"); // insert a string at the specified index
            //int age = 29;
            //message.AppendFormat(" , Your age is {0}", age); // format the string and append it to the StringBuilder
            //message.AppendJoin(", ", "Ahmed", "Ali", "Omar"); // join multiple strings with a separator
            //Console.WriteLine($"Message => {message}");
            #endregion

        }
    }
}

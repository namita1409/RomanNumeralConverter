using System;

namespace RomanNumeral
{
    class RomanNumeral
    {
        public static int DoOperation(string input)
        {
            int result = 0; // Default value

            // Use a Dictionary 
            Dictionary<string, int> my_roman_dict =
                        new Dictionary<string, int>();
            my_roman_dict.Add("I", 1);
            my_roman_dict.Add("II", 2);
            my_roman_dict.Add("III", 3);
            my_roman_dict.Add("IV", 4);
            my_roman_dict.Add("V", 5);
            my_roman_dict.Add("VI", 6);
            my_roman_dict.Add("VII", 7);
            my_roman_dict.Add("VIII", 8);
            my_roman_dict.Add("IX", 9);
            my_roman_dict.Add("X", 10);


            foreach (KeyValuePair<string, int> roman_value in my_roman_dict)
            {

                if (input.ToUpper().Equals(roman_value.Key))
                  return roman_value.Value;
                
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# Roman Numeral Converter app.
            Console.WriteLine("Console Roman Numeral Converter app C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                string user_input = "";                
                int result = 0;

                // Ask the user to enter roman numerals.
                Console.Write("Type a Roman Numeral, and then press Enter: ");
                user_input = Console.ReadLine();

              //  check for empty input 
                while (user_input.Length==0)
                {
                    Console.Write("This is not valid input. Please enter a valid roman numeral ");
                    user_input = Console.ReadLine();
                }             
                
                try
                {
                    result = RomanNumeral.DoOperation(user_input);
                    if (result==0)
                    {
                        Console.WriteLine("This Roman Numeral not present in my Roman dictionary");
                    }
                    else Console.WriteLine("Your Number: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}
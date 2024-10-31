using System;

class Program
{
    static void Main()
    {
        // Main loop to continuously prompt for input
        while (true)
        {
            Console.WriteLine("Enter a number (0 to 9999) or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            // Check if user wants to exit
            if (input == "quit")
                break;

            // Try to parse input as an integer and check if it's in the valid range
            if (int.TryParse(input, out int number) && number >= 0 && number <= 9999)
            {
                string words = NumberToWords(number);
                Console.WriteLine($"{number} -> {words}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 9999.");
            }
        }
    }

    // Convert a number to its word representation
    static string NumberToWords(int number)
    {
        // Special case for zero
        if (number == 0) return "Zero";

        string words = "";

        // Handle thousands
        if (number >= 1000)
        {
            words += UnitsToWords(number / 1000) + " Thousand ";
            number %= 1000;
        }

        // Handle hundreds
        if (number >= 100)
        {
            words += UnitsToWords(number / 100) + " Hundred ";
            number %= 100;
        }

        // Handle tens and units
        if (number >= 20)
        {
            words += TensToWords(number / 10 * 10);
            if (number % 10 != 0)
                words += " " + UnitsToWords(number % 10);
        }
        else if (number > 0)
        {
            words += UnitsToWords(number);
        }

        return words.Trim();
    }

    // Convert units (1-19) to words
    static string UnitsToWords(int number)
    {
        switch (number)
        {
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            case 10: return "Ten";
            case 11: return "Eleven";
            case 12: return "Twelve";
            case 13: return "Thirteen";
            case 14: return "Fourteen";
            case 15: return "Fifteen";
            case 16: return "Sixteen";
            case 17: return "Seventeen";
            case 18: return "Eighteen";
            case 19: return "Nineteen";
            default: return "";
        }
    }

    // Convert tens (20, 30, ..., 90) to words
    static string TensToWords(int number)
    {
        switch (number)
        {
            case 20: return "Twenty";
            case 30: return "Thirty";
            case 40: return "Forty";
            case 50: return "Fifty";
            case 60: return "Sixty";
            case 70: return "Seventy";
            case 80: return "Eighty";
            case 90: return "Ninety";
            default: return "";
        }
    }
}
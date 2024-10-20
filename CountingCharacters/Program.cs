namespace CountingCharacters
{
    internal class Program
    {
        static void Main()
        {
            // prompt the user for a sring 
            Console.WriteLine("Enter a string");
            string userInput = Console.ReadLine();

            // use Dictionary to store the character count
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // loop through each character in the string 
            foreach (char c in userInput) 
            {
                // convert character to lowercase and check if it's alphabetic
                char lowerChar = char.ToLower(c);
                if (char.IsLetter(lowerChar))
                {
                    // update the dictionary with the character count
                    if (charCount.ContainsKey(lowerChar)) 
                    {
                        charCount[lowerChar]++;
                    } else
                    {
                        charCount[lowerChar] = 1;
                    }
                }
            }

            // print the results 
            Console.WriteLine("\nCharacter counts: ");
            foreach (var pair in charCount) 
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            Console.ReadKey();
        }
    }
}


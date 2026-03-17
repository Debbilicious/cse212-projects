public static class UniqueLetters {
    public static void Run() {
        var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        Console.WriteLine(AreUniqueLetters(test1));

        var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        Console.WriteLine(AreUniqueLetters(test2));

        var test3 = "";
        Console.WriteLine(AreUniqueLetters(test3)); // Expect True because it's an empty string
    }

    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    private static bool AreUniqueLetters(string text) {
        // Create a set to track seen letters
        var seenLetters = new HashSet<char>();

        // Loop through each character in the string
        foreach (var ch in text) {
            if (seenLetters.Contains(ch)) {
                // Duplicate found
                return false;
            }
            // Add letter to the set
            seenLetters.Add(ch);
        }

        // No duplicates found
        return true;
    }
}
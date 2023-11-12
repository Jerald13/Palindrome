using System;
using System.Linq;

class PalindromeChecker
{

    public static bool isPalindrome(string inputString, string trashSymbolsString)
    {
        if (string.IsNullOrEmpty(inputString) || inputString.Length == 1)
            return false;

        int start = 0;
        int last = inputString.Length - 1;

        while (start < last)
        {
            if (trashSymbolsString.Contains(inputString[start], StringComparison.OrdinalIgnoreCase))
                start++;

            if (trashSymbolsString.Contains(inputString[last], StringComparison.OrdinalIgnoreCase))
                last--;

            if (char.ToLower(inputString[start]) != char.ToLower(inputString[last]))
                return false;

            start++;
            last--;
        }

        return true;
    }

    static void Main(string[] args)
    {
        string inputString = "a@b!!b$a";
        string trashSymbols = "!@$";

        string inputString2 = "?Aa#c";
        string trashSymbols2 = "#?";

        Console.WriteLine(isPalindrome(inputString, trashSymbols));
        Console.WriteLine(isPalindrome(inputString2, trashSymbols2));

    }

}

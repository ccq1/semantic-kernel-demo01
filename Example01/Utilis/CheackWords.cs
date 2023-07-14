using System.Text.RegularExpressions;

namespace Utilis;

/// <summary>
/// Check the word format,and return the word string
/// </summary>
public static class CheckWords
{
    public static string Check(this string words)
    {
        if(words.Length == 0)
        {
            Console.WriteLine("The number of words cannot be empty");
            return null;
        }
        //Match non-alphabetic content with regex
        Regex regex = new Regex(@"[^a-zA-Z]");
        //Replace non-alphabetic content with spaces
        words = regex.Replace(words, " ");
        //Remove extra spaces
        words = words.Trim();
        words = Regex.Replace(words, @"\s+", " ");
        //Check the number of words
        if (words.Split(' ').Length > 5)
        {
            Console.WriteLine("The number of words cannot exceed 5");
            return null;
        }
        words = words.Replace(" ", ",");
        return words;
    }
}
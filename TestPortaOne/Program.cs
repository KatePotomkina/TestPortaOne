using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestPortaOne;

internal class Program
{
    
    public static void Main(string[] args)
    {
        var text = File.ReadAllText(@"C:\Users\Владелец\RiderProjects\TestPortaOne\TestPortaOne\Text.txt");
        var test1 = SplitTextIntoWords(text);
        Console.WriteLine(FindUniqueElement(SplitWordIntoChar(test1)));
    }
/// <summary>
/// Split the text into array of words using separators
/// </summary>
/// <param name="text"> </param>
/// <returns> string array (every element is a word)</returns>
    public static string[] SplitTextIntoWords(string text)
    {
        var separators = new[] { ' ', '.', '\n', '\t', '\0', '\r', '"', '-','(','[',')',']' };
        var exclusiveChars = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        return exclusiveChars;
    }
/// <summary>
/// Split every element from string array to array of chars and find the first unique value from array
/// </summary>
/// <param name="text"></param>
/// <returns> list of unique elements from all words </returns>
    public static List<string> SplitWordIntoChar(string[] text)
    {
        var exclusiveChar = new List<string>();
        foreach (var symbol in text)
        {
            char[] symbols;
            symbols = symbol.ToCharArray();

            exclusiveChar.Add(symbols.GroupBy(i => i)
                .Where(g => g
                    .Count() == 1).Select(g => g.Key).First().ToString());
        }

        return exclusiveChar;
    }
/// <summary>
/// To find unique value from list 
/// </summary>
/// <param name="arr"></param>
/// <returns>  first unique element </returns>
    public static string FindUniqueElement(List<string> arr)
    {
        var uniqueNumbers = arr.GroupBy(g => g)
            .Where(c => c.Count() == 1)
            .Select(k => k.Key)
            .ToList();
        return uniqueNumbers.First();
    }
}
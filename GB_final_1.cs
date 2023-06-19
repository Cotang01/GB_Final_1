using System;

internal class Program
{
    static void Main()
    {
        
        string[] inputArray = { "hello", "2", "world", ":-)" };

        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }

    }

    static string[] FilterStrings(string[] input)
    {
        string[] tempArray = new string[input.Length];
        int count = 0;

        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                tempArray[count] = str;
                count++;
            }
        }

        string[] resultArray = new string[count];
        Array.Copy(tempArray, resultArray, count);

        return resultArray;
    }
}
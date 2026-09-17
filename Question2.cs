using System;

public class Question2
{
    //setting up Dictionary to reference numbers in string to numbers in integer
    private static (string Word, int Value)[] StringNumberLibrary = new (string, int)[]
    {
            ("one", 1), ("two", 2), ("three", 3), ("four", 4), ("five", 5), ("six", 6), ("seven", 7), ("eight", 8), ("nine", 9)
    };


    public static int SumOfWords(string FilePath)
    {
        int totalSum = 0;

        foreach (string line in File.ReadLines(FilePath))
        {
            // initialize found digit as -1 (flag)
            int firstDigit = -1;
            int lastDigit = -1;

            // Scan each character from left to right in the line
            // Note : do not skip index in scanning even if already found the first integer
            // This is to ensure overlapping text is accounted for in a single line Ex: eightwo 
            for (int i = 0; i < line.Length; i++)
            {
                int digit = DecodetoInteger(line, i);
                
                if (digit != -1)
                {
                    if (firstDigit == -1)
                    {
                        firstDigit = digit;
                    }

                    // once first digit is found, each new found digit will assigned as last digit
                    lastDigit = digit; 
                }
            }

            // Combine first and last digit as number
            if (firstDigit != -1 && lastDigit != -1)
            {
                int lineValue = (firstDigit * 10) + lastDigit;

                //add into total sum
                totalSum += lineValue;
            }
        }

        return totalSum;
    }

    // Decode into Integer
    private static int DecodetoInteger(string line, int startIndex)
    {
        // Check if character is a numeric digit
        if (line[startIndex] >= '0' && line[startIndex] <= '9')
        {
            // minus '0'  to translate ASCII code to integer value
            return line[startIndex] - '0';
        }

        //If is not nbumeric digit, scan each character to match with key word in dictionary
        foreach (var (word, value) in StringNumberLibrary)
        {
            if (startIndex + word.Length <= line.Length)
            {
                // Use C# built in library
                if (string.Compare(line, startIndex, word, 0, word.Length, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return value;
                }
            }
        }

        return -1; 
    }



}
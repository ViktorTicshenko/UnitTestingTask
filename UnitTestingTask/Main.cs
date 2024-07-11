namespace UnitTestingTask;

class Program
{
    // static void Main(string[] args)
    // {
    //     string input = "aaabbcc123333bbb";
    //     Console.WriteLine($"Max Unequal Consecutive Characters: {MaxUnequalConsecutiveCharacters(input)}");
    //     Console.WriteLine($"Max Consecutive Identical Letters: {MaxConsecutiveIdenticalLetters(input)}");
    //     Console.WriteLine($"Max Consecutive Identical Digits: {MaxConsecutiveIdenticalDigits(input)}");
    //     Console.ReadLine();
    // }

    public static int MaxUnequalConsecutiveCharacters(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;

        int maxCount = 1, currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                currentCount++;
            }
            else
            {
                maxCount = Math.Max(maxCount, currentCount);
                currentCount = 1;
            }
        }

        return Math.Max(maxCount, currentCount);
    }

    public static int MaxConsecutiveIdenticalLetters(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;

        int maxCount = 0, currentCount = 0;
        char previousChar = '\0';

        foreach (var ch in input)
        {
            if (char.IsLetter(ch))
            {
                if (ch == previousChar)
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
                previousChar = ch;
            }
            else
            {
                maxCount = Math.Max(maxCount, currentCount);
                currentCount = 0;
                previousChar = '\0';
            }
        }

        return Math.Max(maxCount, currentCount);
    }

    public static int MaxConsecutiveIdenticalDigits(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;

        int maxCount = 0, currentCount = 0;
        char previousChar = '\0';

        foreach (var ch in input)
        {
            if (char.IsDigit(ch))
            {
                if (ch == previousChar)
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
                previousChar = ch;
            }
            else
            {
                maxCount = Math.Max(maxCount, currentCount);
                currentCount = 0;
                previousChar = '\0';
            }
        }

        return Math.Max(maxCount, currentCount);
    }
}
partial class Program
{
    static void ParamVeerChakra()
    {
        Console.WriteLine("These are the men of steel who have giventheir everything to keep our country safe." +
            "With the act of supreme and selfless bravery, they have won the country's highest wartime gallantry award." +
            "\n1.\tSomnath Sharma" +
            "\n2.\tJadunath Singh" +
            "\n3.\tRama Raghoba Rane" +
            "\n4.\tPiru Singh" +
            "\n5.\tKaram Singh" +
            "\n6.\tGurbachan Singh Salaria" +
            "\n7.\tDhan Singh Thapa" +
            "\n8.\tJoginder Singh" +
            "\n9.\tShaitan Singh" +
            "\n10.\tArdesir Burzorji Tarapore" +
            "\n11.\tAbdul Hamid" +
            "\n12.\tAlbert Ekka" +
            "\n13.\tNirmaljit Singh Sekhon" +
            "\n14.\tArun Khetarpal" +
            "\n15.\tHosiar Singh" +
            "\n16.\tBana Singh" +
            "\n17.\tRamaswamy Parmeswaram" +
            "\n18.\tVikram Batra" +
            "\n19.\tManoj Kumar Pandey" +
            "\n20.\tYogendra Singh Yadav" +
            "\n21.\tSanjay Kumar");
    }
    static void DoSomething()
    {
        WriteLine("Doing something!");
    }
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times with {size} rows:");
        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {number} = {row * number}");
        }
        WriteLine();
    }
    /// <summary>
    /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
    /// </summary>
    /// <param name="number">Number as a Cardinal value e.g.1,2,3, and so on.</param>
    /// <returns>Number as an ordinal value e.g.1st,2nd,3rd, and so on.</returns>
    static string CardinalToOrdinal(int number)
    {
        int lastTwoDigit = number % 100;
        switch (lastTwoDigit)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                int lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }
    /// <summary>
    /// Pass a 32-bit integer and it will calculate factorial.
    /// </summary>
    /// <param name="number">Numbers as non negative number e.g. 1,2,3 and so on</param>
    /// <returns>Number as factorial( n * n-1 * n-2 *..*1 ) </returns>
    /// <exception cref="ArgumentException"></exception>
    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(message:
                $"The factorial function is defined for non-negative integers only.Input: {number}",paramName:nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * (Factorial(number - 1));
            }
        }
    }
}
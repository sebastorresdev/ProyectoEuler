var numberOfLettersFromOneToNine = new int[] { 3, 3, 5, 4, 4, 3, 5, 5, 4 };
var numberOfLettersFromTenToNineteen = new int[] { 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
var numbersOfLettersFromTwentyToNinety = new int[] { 6, 6, 5, 5, 5, 7, 6, 6 };

Console.WriteLine(CalculateNumberOfLettersFromHundredOnwards());

int CalculateNumberOfLettersFromHundredOnwards()
{
    var sumOfLettersFromOneToNinetyNine =
        numberOfLettersFromTenToNineteen.Sum() +
        numbersOfLettersFromTwentyToNinety.Sum() * 10 +
        numberOfLettersFromOneToNine.Sum() * 9;

    Console.WriteLine(sumOfLettersFromOneToNinetyNine);

    return numberOfLettersFromOneToNine.Sum() * 100 +
            7 * 900 + // cantidad de veces hundred
            3 * 99 * 9 + // centidad de veces and
            sumOfLettersFromOneToNinetyNine * 10 +
            11; // one thousand
}
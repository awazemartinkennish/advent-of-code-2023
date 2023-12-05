namespace src;
using System.Collections.Generic;

public static class Day1
{
    public static int Part1(List<string> input)
    {
        int ParseNumberFromLine(string line) {
            List<int> numbers = new();
            for (int i = 0; i < line.Length; i++) {
                if (char.IsDigit(line[i])) {
                    numbers.Add(int.Parse(line[i].ToString()));
                }
            }
            if (numbers.Count == 0) {
                return 0;
            } else if (numbers.Count == 1) {
                return int.Parse($"{numbers[0]}{numbers[0]}");
            } else {
                int firstDigit = numbers[0];
                int lastDigit = numbers[numbers.Count - 1];
                return int.Parse($"{firstDigit}{lastDigit}");
            }
        }

        return input.Select(ParseNumberFromLine).Sum();
    }
}

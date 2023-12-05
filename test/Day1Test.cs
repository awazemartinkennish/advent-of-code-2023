namespace test;

public class Day1Test
{
    [Fact]
    public void Part1_Sample()
    {
        List<string> input = new List<string> {
            "1abc2",
            "pqr3stu8vwx",
            "a1b2c3d4e5f",
            "treb7uchet"
        };

        Day1.Part1(input).Should().Be(142);
    }

    [Fact]
    public void Part1_Actual()
    {
        var input = File.ReadLines("inputs/day1.txt").ToList();

        Day1.Part1(input).Should().Be(54304);
    }
}

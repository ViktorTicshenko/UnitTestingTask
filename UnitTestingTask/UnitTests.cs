namespace UnitTestingTask;

[TestFixture]
public class ProgramTests
{
    [Test]
    public void MaxUnequalConsecutiveCharacters_AllUnique_ReturnsLength()
    {
        var input = "abcdef";
        var result = Program.MaxUnequalConsecutiveCharacters(input);
        
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void MaxUnequalConsecutiveCharacters_SomeRepeats_ReturnsMaxCount()
    {
        var input = "aaabbcc";
        var result = Program.MaxUnequalConsecutiveCharacters(input);

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void MaxUnequalConsecutiveCharacters_EmptyString_ReturnsZero()
    {
        var input = "";
        var result = Program.MaxUnequalConsecutiveCharacters(input);

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxConsecutiveIdenticalLetters_SomeRepeats_ReturnsMaxCount()
    {
        var input = "aaabbccddd";
        var result = Program.MaxConsecutiveIdenticalLetters(input);

        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void MaxConsecutiveIdenticalLetters_AllUnique_ReturnsOne()
    {
        var input = "abcdef";
        var result = Program.MaxConsecutiveIdenticalLetters(input);

        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void MaxConsecutiveIdenticalLetters_EmptyString_ReturnsZero()
    {
        var input = "";
        var result = Program.MaxConsecutiveIdenticalLetters(input);

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxConsecutiveIdenticalDigits_SomeRepeats_ReturnsMaxCount()
    {
        var input = "1122334444";
        var result = Program.MaxConsecutiveIdenticalDigits(input);

        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void MaxConsecutiveIdenticalDigits_AllUnique_ReturnsOne()
    {
        var input = "123456";
        var result = Program.MaxConsecutiveIdenticalDigits(input);

        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void MaxConsecutiveIdenticalDigits_EmptyString_ReturnsZero()
    {
        var input = "";
        var result = Program.MaxConsecutiveIdenticalDigits(input);

        Assert.That(result, Is.EqualTo(0));
    }
}
using NUnit.Framework;

namespace NunitTests;

public class ConstraintModelAssertions
{
    [Test]
    public void WordsAreEqual()
    {
        Assert.That("Life", Is.EqualTo("life").IgnoreCase);
    }

    [Test]
    public void WordContainsACharacter()
    {
        Assert.That("Hell".Contains('e'));
    }

    [Test]
    public void ArrayHasSingleOccurenceOfDigit()
    {
        var input = new int[] { 1, 4, 3 };
        Assert.That(input, Has.Exactly(1).EqualTo(4));
    }

    [TestCase(1, 8, 10)]
    [Pairwise]
    public void IsGreaterThanFirstAndLessThanSecondAndNotLast([Values(1, 2, 4)] int first, [Values(8, 9)] int second,
        [Values(10)] int last)
    {
        var actual = 7;
        Assert.That(actual, Is.GreaterThan(5).And.LessThan(10).And.Not.EqualTo(89));

        TestContext.AddTestAttachment(@"C:\Users\Sudha\OneDrive\Pictures\Test.PNG", "Failed screen");
    }
}
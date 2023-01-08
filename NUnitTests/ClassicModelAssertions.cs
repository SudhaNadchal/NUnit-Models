using NUnit.Framework;

namespace NunitTests;

public class ClassicModelAssertions
{
    [Test]
    public void AreEqualStrings()
    {
        Assert.AreEqual("Life", "Life", "Meaning of what  {0} is", "Life");
    }

    [Test]
    public void AreEqualNUmbers()
    {
        Assert.AreEqual(1, 1.0);
    }

    [Test]
    public void AreEqualWithTolerance()
    {
        Assert.AreEqual(1, 1.2, 0.3);
    }

    [Test]
    public void AreEqualArrays()
    {
        var expected = new int[] { 1, 2, 3, 4, 5 };
        var actual = new int[] { 1, 3, 2, 4, 5 };
        Array.Sort(actual);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void AreNotSameObjects()
    {
        var obj1 = new Object();
        var obj2 = new Object();
        Assert.AreNotSame(obj1, obj2);
    }

    [Test]
    public void AreSameObjects()
    {
        var obj1 = new Object();
        var obj2 = obj1;
        Assert.AreSame(obj1, obj2);
    }
}
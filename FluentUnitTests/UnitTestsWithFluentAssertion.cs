using FluentAssertions;
using NUnit.Framework;

namespace FluentUnitTests;

public class Tests
{
    [Test]
    public void TestWithFluentAssertions()
    {
        "Test".Should().ContainAny("e");
    }
}
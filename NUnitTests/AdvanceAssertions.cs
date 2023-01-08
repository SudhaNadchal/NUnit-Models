using NUnit.Framework;
using System;
using NUnit.Framework.Interfaces;

namespace NunitTests;

public class AdvanceAssertions
{
    [Test]
    [Explicit("I choose to run explicitely")]
    [Category("AdvanceAssertions")]
    public void AssertWarnings()
    {
        var isProcessed = true;
        Warn.Unless(isProcessed, Is.EqualTo(false).After(1000).PollEvery(1000), "Waiting for Process");
    }

    [Test]
    [Order(2)]
    [Ignore("I choose to ignore")]
    [Category("AdvanceAssertios")]
    [Platform(Exclude = "Win")]
    public void AssertAssumptions()
    {
        bool isConfigEnabled = true;
        Assume.That(isConfigEnabled, Is.True);
        Assert.That("actual", Is.EqualTo("actual"));
    }

    [Test]
    [Order(1)]
    public void MultipleAssertions()
    {
        Assert.Multiple((() =>
        {
            Assert.That(1, Is.GreaterThan(0));
            Assert.That("wow", Contains.Item('o'));
        }));
    }
}
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProcessor;

namespace StringProcessor.Tests;

[TestClass]
[TestSubject(typeof(StringProcessor))]
public class StringProcessorTest
{

    [TestMethod]
    public void ReplaceDWithTTest()
    {
        var result = StringProcessor.ReplaceDWithT("Hello world");
        Assert.AreEqual("Hello Hello worlt worlt ", result);
    }
}
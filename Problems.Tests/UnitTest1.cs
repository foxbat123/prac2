using NUnit.Framework;
using Problems; 
using System.Collections;
using System; 


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /* [Test]
        public void Test1()
        {
            Program p = new Program(); 
            string result = p.Prefix("hello");
            Assert.AreEqual("5,1:hello", result);
        }

        [Test]
        public void Test2()
        {
            Program p = new Program(); 
            string result = p.Prefix("");
            Assert.AreEqual("0,0:", result);
        }

        [Test]
        public void Test3()
        {
            Program p = new Program(); 
            string result = p.Prefix("what ... did you say?? ");
            Assert.AreEqual("23,5:what ... did you say?? ", result);
        } */

[TestFixture]
public class MyTests
{
    [TestCaseSource(typeof(MyDataClass), "TestCases")]
    public string StringTest(string x)
    {
        Program p = new Program(); 
        string result = p.Prefix(x);
        return result; 
    }
}
public class MyDataClass
{
    public static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData("what ... did you say?? ").Returns("23,5:what ... did you say?? ");
            yield return new TestCaseData("hello").Returns("5,1:hello");
            yield return new TestCaseData("").Returns("0,0:");
            yield return new TestCaseData("bob").Returns("3,1:bob");
            yield return new TestCaseData("   ").Returns("3,0:   ");
            yield return new TestCaseData("moo cow").Returns("7,2:moo cow");
        }
    }  
}



        /* [TestCase("what ... did you say?? "), ExpectedResult="23,5:what ... did you say?? "]
        [TestCase("hello"), ExpectedResult="5,1:hello"]
        public void StringTest(string x)
        {
            return x; 
        } */

    }
}
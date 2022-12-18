using NUnit.Framework;

namespace HelloWorld_Nunit_Test
{
    [TestFixture]
    public class HelloWorldTests
    {
        [Test]
        public void TestHelloWorld()
        {
            var helloWorld = new HelloWorld();
            var result = helloWorld.Greet();
            Assert.AreEqual("Hello, World!", result);
        }
    }

    public class HelloWorld
    {
        public string Greet()
        {
            return "Hello, World!";
        }
    }
}

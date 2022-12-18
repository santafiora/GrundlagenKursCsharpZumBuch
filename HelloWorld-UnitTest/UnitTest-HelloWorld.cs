NUnit Test

using NUnit.Framework;

namespace HelloWorldProgram.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Main_WhenCalled_ShouldWriteHelloWorld()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                Program.Main(null);

                Assert.AreEqual("Hello World!\r\n", sw.ToString());
            }
        }
    }
}

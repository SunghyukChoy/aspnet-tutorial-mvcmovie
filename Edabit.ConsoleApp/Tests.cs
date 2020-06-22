using NUnit.Framework;

namespace Edabit.ConsoleApp
{
    public class Tests
    {
        [Test]
        [TestCase("HELLO", Result = true)]
        [TestCase("HEllo", Result = false)]
        [TestCase("mArmALadE", Result = false)]
        [TestCase("marmalade", Result = true)]
        [TestCase("MARMALADE", Result = true)]
        [TestCase("ketchUP", Result = false)]
        [TestCase("pickle", Result = true)]
        [TestCase("MUSTARD", Result = true)]
        public static bool FixedTest(string str)
        {
            return Program.SameCase(str);
        }
    }
}

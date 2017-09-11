
using System;
using NUnit.Framework;

namespace Anagrams.Tests
{
    [TestFixture]
    public class AnagramModelTests
    {

        //AnagramModel model = new AnagramModel();
        [Test]
        public void Pass()
        {
            Assert.True(true);
        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }
    }
}

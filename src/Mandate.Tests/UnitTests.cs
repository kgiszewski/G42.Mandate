using System;
using NUnit.Framework;

namespace Mandate.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Will_Not_Throw_For_That()
        {
            Assert.DoesNotThrow(() =>
            {
                G42.Mandate.Mandate.That<Exception>(true, "");
            });
        }

        [Test]
        public void Will_Throw_For_That()
        {
            Assert.Throws<Exception>(() =>
            {
                G42.Mandate.Mandate.That<Exception>(false, "");
            });
        }

        [Test]
        public void Will_Not_Throw_When_Not_Null()
        {
            Assert.DoesNotThrow(() =>
            {
                G42.Mandate.Mandate.IsNotNull<Exception>(new {}, "");
            });
        }

        [Test]
        public void Will_Throw_When_Null()
        {
            Assert.Throws<Exception>(() =>
            {
                G42.Mandate.Mandate.IsNotNull<Exception>(null, "");
            });
        }
    }
}

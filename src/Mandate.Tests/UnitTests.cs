using System;
using System.Collections.Generic;
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
                G42.Mandate.Mandate.IsNotNull<Exception>(new { }, "");
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

        [Test]
        public void Can_Pass_Args_In_Custom_Exception()
        {
            try
            {
                G42.Mandate.Mandate.That<FooException>(false, "Hi there.", new List<object> { "hello world" }.ToArray());
            }
            catch (FooException ex)
            {
                var args = ex.Args;

                Assert.AreEqual(1, args.Length);
                Assert.AreEqual("hello world", args[0]);
            }
        }
    }
}
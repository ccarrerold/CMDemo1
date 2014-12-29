using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace ClearMeasure.Library.UnitTests.Tests
{
    [TestFixture]
    public class when_using_only_custom_rules : ClearMeasureUnitTest
    {
        private CMUtilities Utilities = null;

        protected override void Setup()
        {
            base.Setup();
            var customRules = this.GetCustomRules();
            Utilities = new CMUtilities(false, customRules);
        }

        protected virtual Dictionary<int, string> GetCustomRules()
        {
            return new Dictionary<int, string>()
            {
                { 3, "foo" },
                { 5, "bar" }
            };
        }

        [Test]
        public void number_divisible_by_3_and_not_5_returns_foo()
        {
            var value = this.Utilities.GetOutput(3);
            Assert.AreEqual(value, "foo");
        }

        [Test]
        public void number_divisible_by_5_and_not_3_returns_bar()
        {
            var value = this.Utilities.GetOutput(5);
            Assert.AreEqual(value, "bar");
        }

        [Test]
        public void number_divisible_by_3_and_5_returns_foobar()
        {
            var value = this.Utilities.GetOutput(15);
            Assert.AreEqual(value, "foobar");
        }

        [Test]
        public void number_not_divisible_by_3_or_5_returns_formal_parameter()
        {
            var parameter = 7;
            var value = this.Utilities.GetOutput(parameter);
            Assert.AreEqual(value, parameter.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

namespace ClearMeasure.Library.UnitTests.Tests
{
    [TestFixture]
    public class when_using_default_rules : ClearMeasureUnitTest
    {
        [Test]
        public void rules_are_not_duplicated()
        {
            foreach (var group in CMUtilities.DefaultRules.GroupBy(x => x.Key))
            {
                if (group.Count() > 1)
                {
                    Assert.Fail("The default rules contains duplicate keys for " + group.First().Key.ToString() + ".");
                }
            }
        }

        [Test]
        public void duplicating_default_rule_keys_throws_exception()
        {
            var rules = new Dictionary<int, string>();

            foreach (var rule in CMUtilities.DefaultRules)
            {
                rules.Add(rule.Key, rule.Value);
            }

            try
            {
                new CMUtilities(true, rules);
            }
            catch (DuplicateRuleException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
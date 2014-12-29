using NUnit.Framework;

namespace ClearMeasure.Library.UnitTests
{
    [TestFixture]
    public class ClearMeasureUnitTest
    {
        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            Setup();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            TearDown();
        }

        protected virtual void Setup()
        { }

        protected virtual void TearDown()
        { }
    }
}

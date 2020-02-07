using NUnit.Framework;
using TechFabricSln;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(false);
        }

        [Test]
        public void IsBoughtBy_UserIsCustomer_ReturnTrue()
        {
            var bought = new Bought();
            var result = bought.IsBoughtBy(new User { Customer = true });
            Assert.IsTrue(result);
        }
    }
}
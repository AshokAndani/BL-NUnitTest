using FakeTest;
using NUnit.Framework;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace FakeTests
{
    public class UserProfileBuilderTests
    {

        public UserProfileBuilder profileBuilder;
        [SetUp]
        public void Setup()
        {
            // fake setup which is hardcoded
            IDataProvider provider = new StubDataProvider();

            this.profileBuilder= new UserProfileBuilder(12,provider);
        }

        [Test]
        public void Test1()
        {
            var result=this.profileBuilder.SetUsername();
            Assert.AreEqual("ashok",result);
        }
    }
}
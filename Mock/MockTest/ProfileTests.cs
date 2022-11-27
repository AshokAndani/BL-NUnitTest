using Moq;
using NUnit.Framework;
using UnitTestTypes;

namespace MockTest
{
    public class ProfileTests
    {
        public UserProfileBuilder ProfileBuilder;
        [SetUp]
        public void Setup()
        {
            // mocking the object
            Mock<IDataProvider> provider = new Mock<IDataProvider>();

            //setting up the data
            string username = "ashok";

            // setup method calls
            provider.Setup(x => x.GetUserName(It.IsAny<int>())).Returns(username);
            
            // building the main object that needs dependant objects
            this.ProfileBuilder = new UserProfileBuilder(12, provider.Object);
        }

        [Test]
        public void Test1()
        {
            var result=ProfileBuilder.SetUserName();
            
            Assert.AreEqual("ashok",result);
        }
    }
}
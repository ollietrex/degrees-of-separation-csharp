using System.Linq;
using Foo.v1.MonkeyService.Api.ServiceModel;
using NUnit.Framework;
using ServiceStack;

namespace Foo.v1.MonkeyService.Api.Tests
{
    public class MonkeyTests
    {
        protected string ListeningOn = "http://127.0.0.1:9876/";
        protected ServiceStackHost AppHost { get; set; }
        protected IServiceClient Client { get; set; }

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            AppHost = new AppHost().Init().Start(ListeningOn);
            Client = new JsonServiceClient(ListeningOn);
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            if (AppHost != null)
            {
                AppHost.Dispose();
            }
            if (Client != null)
            {
                Client.Dispose();
            }
        }

        [Test]
        public void GetAllMonkeysTest()
        {
            var response = Client.Get(new GetMonkeys());
            Assert.IsTrue(response.Monkeys.Any());
        }


    }
}

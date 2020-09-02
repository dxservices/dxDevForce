using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;
using devBuilder.ServiceInterface;
using devBuilder.ServiceModel;

namespace devBuilder.Tests
{
    public class UnitTest
    {
        private readonly ServiceStackHost appHost;

        public UnitTest()
        {
            appHost = new BasicAppHost().Init();
            appHost.Container.AddTransient<FormServices>();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => appHost.Dispose();

        [Test]
        public void Can_call_MyServices()
        {
            // var service = appHost.Container.Resolve<MyServices>();
            //
            // var response = (HelloResponse)service.Any(new Hello { Name = "World" });
            //
            // Assert.That(response.Result, Is.EqualTo("Hello, World!"));
        }
    }
}

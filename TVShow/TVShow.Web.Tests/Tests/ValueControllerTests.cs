using MyTested.AspNetCore.Mvc;
using NUnit.Framework;
using TVShow.Web.Api;

namespace TVShow.Web.Tests
{

    [TestFixture]
    public class ValueControllerTests
    {

        [Test]
        public void ReturnOkWhenCallingGetAction()
        {
            MyController<ValueController>
                .Instance()
                .Calling(p => p.Get())
                .ShouldReturn()
                .Ok(result => result
                        .WithModelOfType<string[]>());
        }
    }
}
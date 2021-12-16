using MyTested.AspNetCore.Mvc;
using NUnit.Framework;
using TVShows.Web.Api;

namespace TVShows.Web.Tests
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
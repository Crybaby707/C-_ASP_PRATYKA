using MyTested.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using TVShows.Data;
using TVShows.Domain;
using TVShows.Web.Api;
using TVShows.Web.Dto;

namespace TVShows.Web.Tests
{

    [TestFixture]
    public class RoleControllerTests
    {

        [Test]
        public void ReturnOkWhenCallingGetAction()
        {
            MyController<RoleController>
                .Instance()
                .Calling(p => p.Get())
                .ShouldReturn()
                .Ok(result =>
                result.WithModelOfType<List<RoleDto>>()
                .Passing(check => check.Count > 0));
        }
    }
}
using MyTested.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using TVShow.Data;
using TVShow.Domain;
using TVShow.Web.Api;
using TVShow.Web.Dto;

namespace TVShow.Web.Tests
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
﻿using Microsoft.AspNetCore.Mvc;
using System.Net;
using TVShows.Web.Dto;
using TVShows.Web.Errors;
using TVShows.Web.Services;

namespace TVShows.Web.Api
{
    [Route("api/auth")]
    public class AuthController : BaseController
    {
        private readonly IIdentityService userService;

        public AuthController(IIdentityService userService)
        {
            this.userService = userService;
        }



        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(TokenDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BadRequestMessage), (int)HttpStatusCode.BadRequest)]
        public IActionResult Post([FromBody]LoginDto userParam)
        {
            var token = userService.Authenticate(userParam.Email, userParam.Password);

            if (token == null)
            {
                return BadRequest(new BadRequestMessage()
                {
                    Message = "Username or password is incorrect"
                });
            }

            return Ok(new TokenDto()
            {
                Token = token
            });
        }
    }

}

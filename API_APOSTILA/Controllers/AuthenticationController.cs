using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using API_APOSTILA.Domain.Models;
using API_APOSTILA.Domain.Services;
using API_APOSTILA.Resources;
using System;
using Newtonsoft.Json.Linq;
using API_APOSTILA.Util;
using API_APOSTILA.Extensions;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;


namespace API_APOSTILA.Controllers
{
    [Route("/api/[controller]")]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthenticationController(IUserService userService, IMapper mapper, IConfiguration configuration)
        {
            _userService = userService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> VerifyLogin([FromBody] AuthUserResource resource)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.GetErrorMessages());

                var user = _mapper.Map<AuthUserResource, User>(resource);
                var result = await _userService.FirstOrDefaultAsync(user.Login, user.Password);

                if (result == null)
                    return BadRequest("Erro ao tentar realizar o login.");

                var token = Criptografia.GenerateToken(_configuration, user);

                return Ok(new
                {
                    error = false,
                    result = new
                    {
                        token,
                        user = new { user.Id, user.Login }
                    }
                });

            }

            catch (Exception ex)
            {
                var message = "Falaha ao tentar realizar o login.";
                return BadRequest(new { error = true, result = new { message } });
            }

        }

    }
}

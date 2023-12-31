﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YetgenAkbankJump.OOPConsole.Utility;
using YetgenAkbankJump.Shared.Utility;

namespace YetgenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordsController : ControllerBase
    {
        private readonly PasswordGenerator _passwordGenerator;
        private readonly RequestCountService _requestCountService;

        public PasswordsController(PasswordGenerator passwordGenerator, RequestCountService requestCountService)
        {
            _passwordGenerator = passwordGenerator;
            _requestCountService = requestCountService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _requestCountService.Count += 1;
            return Ok(_passwordGenerator.Generate(12, true, true, true, true));
        }

        [HttpGet]
        public IActionResult GetCount()
        {
            _requestCountService.Count += 1;

            return Ok(_passwordGenerator.GeneratedPasswordsCount);
        }

        [HttpGet("GetRequestCount")]
        public IActionResult GetRequestCount()
        {
            _requestCountService.Count += 1;

            return Ok(_requestCountService.Count);
        }
    }
}

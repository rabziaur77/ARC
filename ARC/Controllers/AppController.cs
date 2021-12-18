using ARC.Models;
using ARC.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARC.Controllers
{
    public class AppController : Controller
    {
        private readonly IRepo _Repo;
        private readonly IConfiguration configuration;
        private readonly ILogger<AppController> _logger;
        private readonly EmailModel emailModel;
        public AppController(IRepo Repo, IConfiguration configuration, ILogger<AppController> logger)
        {
            _logger = logger;
            this.configuration = configuration;
            this._Repo = Repo;
            emailModel = new EmailModel()
            {
                SMTP_NAME = this.configuration.GetSection("EmailSetup:SMTP_NAME").Value,
                SMTP_PORT = Convert.ToInt32(this.configuration.GetSection("EmailSetup:SMTP_PORT").Value),
                SMTP_SSL = Convert.ToBoolean(this.configuration.GetSection("EmailSetup:SMTP_SSL").Value),
                UserName = this.configuration.GetSection("EmailSetup:UserName").Value,
                From_User = this.configuration.GetSection("EmailSetup:From_User").Value,
                To_User = this.configuration.GetSection("EmailSetup:To_User").Value,
                Password = this.configuration.GetSection("EmailSetup:Password").Value,
                IsHtml = Convert.ToBoolean(this.configuration.GetSection("EmailSetup:IsHtml").Value)
            };
        }
        [HttpPost]
        public IActionResult SendEmail([FromBody] RequestEmail requestEmail)
        {
            string Response = "";
            if (ModelState.IsValid)
            {
                emailModel.Subject = requestEmail.Subject;
                emailModel.Body = requestEmail.Body;
                Response = _Repo.SendEMail(emailModel);
                return Ok(Response);
            }
            else
                return BadRequest("Bad Requiest.");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Business.Contracts;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace makash_api_study.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme + ",ApiKey")]
    public class HomeController : Controller
    {

        private readonly IServiceWrapper service;

        public HomeController(IServiceWrapper service)
        {
            this.service = service;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var emp_date = await service.makash_serv.Get_Employees();
                return Ok(emp_date);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

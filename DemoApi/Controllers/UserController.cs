using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.DTO;
using Domain;
using Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var students = userService.GetAll();
                return Ok(students);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpPost]
        public ActionResult Post(UserDTO user)
        {
            try
            {
                bool result = userService.Save(user.DTOtoEntity());
                if(result==true)
                    return Ok();
                else
                    return StatusCode(500, "Internal server error");
            }
            catch(Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

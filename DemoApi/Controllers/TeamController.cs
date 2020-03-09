using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Domain.DTO;
namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private ITeamService teamService;
        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var teams = teamService.GetAll();
                return Ok(teams);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var team = teamService.GetById(id);
                if(team!=null)
                    return Ok(team);
                else
                    return StatusCode(500, "Internal server error");
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post(TeamDTO team)
        {
            try
            {
                var result = teamService.Save(team.DTOtoEntity());
                if(result==true)
                    return Ok();
                else
                    return StatusCode(500, "Internal server error");
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

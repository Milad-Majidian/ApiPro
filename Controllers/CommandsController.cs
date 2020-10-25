using System.Collections.Generic;
using commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepository _repository = new MockCommanderRepository();
      [HttpGet]
       public ActionResult<IEnumerable<Command>> GetAllCommands()
       {
           var commandItems = _repository.GetAppCommands();
           return Ok(commandItems);
       }

       [HttpGet("{id}")]
       public ActionResult<Command> GetCommandById(int id)
       {
           var commandItems = _repository.GetCommandById(id);
           return Ok(commandItems);
       }
    }
}
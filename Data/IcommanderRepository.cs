
using System.Collections.Generic;
using Commander.Models;

namespace commander.Data{
    public interface   IcommanderRepository
    {
       IEnumerable<Command> GetAppCommands();
       Command GetCommandById(int id);
    }

}
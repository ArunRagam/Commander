using System.Collections.Generic;

namespace Commander.Data
{
    public interface ICommandReadRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandId(int id);
         
    }

}
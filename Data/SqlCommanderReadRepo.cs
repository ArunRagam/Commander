using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderReadRepo : ICommandReadRepo
    {
        private readonly CommanderContext _commanderContext;
        public SqlCommanderReadRepo(CommanderContext commanderContext)
        {
            _commanderContext = commanderContext;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _commanderContext.Commands.ToList();
        }

        public Command GetCommandId(int id)
        {
            return _commanderContext.Commands.FirstOrDefault(i => i.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderWriteRepo : ICommandWriteRepo
    {
        private readonly CommanderContext _commanderContext;
        public SqlCommanderWriteRepo(CommanderContext commanderContext)
        {
            _commanderContext = commanderContext;
        }

        public void CreateCommand(Command command)
        {
            if (_commanderContext == null)
            {
                throw new ArgumentNullException(nameof(_commanderContext));
            }
            _commanderContext.Add(command);
        }
        public bool SaveChanges()
        {
            return (_commanderContext.SaveChanges() >= 0);
        }
    }
}

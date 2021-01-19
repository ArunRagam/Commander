using Commander.Dtos;
using System.Collections.Generic;

namespace Commander.Data
{
    public interface ICommandWriteRepo
    {
        void CreateCommand(Command command);
        bool SaveChanges();
         
    }

}
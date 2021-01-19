using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommandRepo : ICommandReadRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id=0, HowTo="Boil an Egg",Line ="Boil water",Platform = "Kettle & Pan" },
                new Command { Id=1, HowTo="Cut bread",Line ="Get a knife", Platform = "Knief & Chopping board" },
                new Command { Id=2, HowTo="Make cup of T",Line ="Place T bag in cup", Platform = "Kettle & Cup" }
            };
            return commands;
        }
        public Command GetCommandId(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "Boil an Egg",
                Line = "Boil water",
                Platform = "Kettle & Pan"
            };
        }
    }
}
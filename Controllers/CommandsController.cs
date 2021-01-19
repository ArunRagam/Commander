using System.Collections.Generic;
using System.Security.Cryptography;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        //private readonly MockCommandRepo _mockRepo = new MockCommandRepo();
        private readonly ICommandReadRepo _commandReadRepo;
        private readonly ICommandWriteRepo _commandWriteRepo;
        private readonly IMapper _mapper;

        public CommandsController(ICommandReadRepo commandReadRepo, IMapper mapper, ICommandWriteRepo commandWriteRepo)
        {
            _commandReadRepo = commandReadRepo;
            _commandWriteRepo = commandWriteRepo;
            _mapper = mapper;
        }


        //Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommand()
        {
            var commandItems = _commandReadRepo.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }
        //Get api/commands/1
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetAllCommandId(int Id)
        {
            var commandItems = _commandReadRepo.GetCommandId(Id);
            if (commandItems != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItems));
            }
            return NotFound();

        }

        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _commandWriteRepo.CreateCommand(commandModel);
            _commandWriteRepo.SaveChanges();
            return Ok();

        }
    }
}
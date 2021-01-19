using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();

            CreateMap<CommandCreateDto,Command>();
        }
    }
}

using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsWebAPI
{
    [TestFixture]
    public class Commands_Test
    {
        private Command cmd;
        private readonly ICommanderRepo _repo;
        private readonly IMapper _mapper;

        [Test]
        public void IsReturning_DatabsebyID()
        {
            var commandItem = _repo.GetCommandById(1);
            var cmd2 = _mapper.Map<CommandReadDto>(commandItem);
            cmd = new Command(1, "How to create migrations", "dotnet ef migrations add <Name of Migration>");
            Assert.Equals(cmd, cmd2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Api.UnitOfWork;
using Api.UnitOfWork.commands;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace Api
{
    public class TravelerRepository : ITravelerRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionStr;
        private readonly IWorker _worker;
        private readonly ICommandLine _commandLine;

        public void Create(Community entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Community> GetAll()
        {
            throw new NotImplementedException();
        }

        public Community GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> MyCustomRepositoryMethodExampleAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Community entity, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCommunity(Community entity)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Api.UnitOfWork;
using Api.UnitOfWork.commands;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace Api
{
    public class CommunityRepository : ICommunityRepository
    {

        private readonly IConfiguration _configuration;
        private readonly string _connectionStr;
        private readonly IWorker _worker;
        private readonly ICommandLine _commandLine;

        public CommunityRepository(IConfiguration configururation, IWorker worker, ICommandLine commandLine)
        {
            _configuration = configururation;
            _worker = worker;
            _commandLine = commandLine;
            _connectionStr = _configuration.GetConnectionString("Default");
        }
        public void Create(Community entity)
        {
            _worker.ExecuteCommand(_connectionStr, conn => {
            var query = conn.Query<Community>(_commandLine.AddCommunity,
                new
                {
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Age = entity.Age,
                    Sex = entity.Sex,
                    Language = entity.Language,
                    Region = entity.Region,
                    SubcityOrZone = entity.SubcityOrZone,
                    Sefer = entity.Sefer,
                    Woreda = entity.Woreda,
                    Kebele = entity.Kebele,
                    Occupation = entity.Occupation,
                    HouseNo = entity.HouseNo,
                    PhoneNo = entity.PhoneNo,
                    Latitude = entity.Latitude,
                    Longitude = entity.Longitude,
                    Fever = entity.Fever,
                    Cough = entity.Cough,
                    HasSob = entity.HasSob,
                    FormStatus = entity.FormStatus,
                    TravleHx = entity.TravleHx,  // This's a typo 
                    HaveSex = entity.HaveSex,  // Interesting choice of word 
                    AnimalMarket = entity.AnimalMarket,
                    HealthFacility = entity.HealthFacility,
                    CommunityOccupation = entity.CommunityOccupation  // I would rather say 'Staff' or 'Employee' or 'CollectedBy'
                });
            });
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

        public void Update(Community entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
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
            _worker.ExecuteCommand(_connectionStr, conn =>
            {
                conn.Query<Community>(_commandLine.AddCommunity,
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
                        TravleHx = entity.TravleHx,
                        HaveSex = entity.HaveSex,
                        AnimalMarket = entity.AnimalMarket,
                        HealthFacility = entity.HealthFacility,
                        CommunityOccupation = entity.CommunityOccupation
                    });
            });
        }

        public void Delete(int id)
        {
            _worker.ExecuteCommand(_connectionStr, conn =>
            {
                conn.Query<Community>(_commandLine.RemoveCommunity, new { CommunityID = id });
            });
        }

        public List<Community> GetAll()
        {
            var queryForAllCommunity = _worker.ExecuteCommand(_connectionStr,
            conn => conn.Query<Community>(_commandLine.GetCommunity)).ToList();
            return queryForAllCommunity;
        }

        public Community GetById(int id)
        {
            Community queryById = _worker.ExecuteCommand<Community>(_connectionStr, conn =>
            conn.Query<Community>(_commandLine.GetCommunityById, new { @CommunityID = id }).SingleOrDefault());
            return queryById;
        }

        public void Update(Community entity, int id)
        {

            _worker.ExecuteCommand(_connectionStr, conn =>
              {
                  conn.Query<Community>(_commandLine.UpdateCommunity,
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
                  TravleHx = entity.TravleHx,
                  HaveSex = entity.HaveSex,
                  AnimalMarket = entity.AnimalMarket,
                  HealthFacility = entity.HealthFacility,
                  CommunityOccupation = entity.CommunityOccupation,
                  CommunityID = id
              });
              });

        }
    }
}

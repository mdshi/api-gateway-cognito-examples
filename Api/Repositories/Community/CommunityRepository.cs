using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayer;

namespace Api
{
    public class CommunityRepository : SqlRepository<Community>, ICommunityRepository
    {
        public CommunityRepository(string connectionString) : base(connectionString) { }

        public override async void DeleteAsync(int id)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "DELETE FROM Communities WHERE CommunityID = @CommunityID";
                var parameters = new DynamicParameters();
                parameters.Add("@CommunityID", id, System.Data.DbType.Int32);
                await conn.QueryFirstOrDefaultAsync<Community>(sql, parameters);
            }
        }

        public override async Task<IEnumerable<Community>> GetAllAsync()
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "SELECT * FROM Communities";
                return await conn.QueryAsync<Community>(sql);
            }
        }

        public override async Task<Community> FindAsync(int id)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "SELECT * FROM Communities WHERE CommunityID = @CommunityID";
                var parameters = new DynamicParameters();
                parameters.Add("@CommunityID", id, System.Data.DbType.Int32);
                return await conn.QueryFirstOrDefaultAsync<Community>(sql, parameters);
            }
        }

        public override async void InsertAsync(Community entity)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "INSERT INTO Communities(FirstName, LastName, Age, Sex, Language, Region, SubcityOrZone, Sefer, " +
                    "Woreda, Kebele, Occupation, HouseNo, PhoneNo, Latitude, Longitude, Fever, Cough, HasSob, FormStatus, TravleHx," +
                    "HaveSex, AnimalMarket, HealthFacility, CommunityOccupation)"
                    + "VALUES(@FirstName, @LastName,@Age, @Sex, @Language, @Region, @SubcityOrZone, @Sefer, @Woreda, @Kebele,"
                    + "@Occupation, @HouseNo, @PhoneNo, @Latitude, @Longitude, @Fever, @Cough, @HasSob, @FormStatus, @TravleHx, @HaveSex, "
                    + "@AnimalMarket, @HealthFacility, @CommunityOccupation)";
                //Community enitity = new Community();
                var parameters = GetParameters();
                parameters.Add("@FirstName", entity.FirstName, DbType.String);
                parameters.Add("@LastName", entity.LastName, DbType.String);
                parameters.Add("@Age", entity.Age, DbType.Int64);
                parameters.Add("@Sex", entity.Sex, DbType.String);
                parameters.Add("@Language", entity.Language, DbType.String);
                parameters.Add("@Region", entity.Region, DbType.String);
                parameters.Add("@SubcityOrZone", entity.SubcityOrZone, DbType.String);
                parameters.Add("@Sefer", entity.Sefer, DbType.String);
                parameters.Add("@Woreda", entity.Woreda, DbType.String);
                parameters.Add("@Kebele", entity.Kebele, DbType.String);
                parameters.Add("@Occupation", entity.Occupation, DbType.String);
                parameters.Add("@HouseNo", entity.HouseNo, DbType.String);
                parameters.Add("@PhoneNo", entity.PhoneNo, DbType.Int64);
                parameters.Add("@Latitude", entity.Latitude, DbType.String);
                parameters.Add("@Longitude", entity.Longitude, DbType.String);
                parameters.Add("@Fever", entity.Fever, DbType.Boolean);
                parameters.Add("@Cough", entity.Cough, DbType.Boolean);
                parameters.Add("@HasSob", entity.HasSob, DbType.Boolean);
                parameters.Add("@FormStatus", entity.FormStatus, DbType.String);
                parameters.Add("@TravleHx", entity.TravleHx, DbType.Boolean);
                parameters.Add("@HaveSex", entity.HaveSex, DbType.Boolean);
                parameters.Add("@AnimalMarket", entity.AnimalMarket, DbType.Boolean);
                parameters.Add("@HealthFacility", entity.HealthFacility, DbType.Boolean);
                parameters.Add("@CommunityOccupation", entity.CommunityOccupation, DbType.String);
                await conn.QueryFirstAsync(sql, parameters);
            }
        }

        private static DynamicParameters GetParameters()
        {
            return new DynamicParameters();
        }

        public override async void UpdateAsync(Community entityToUpdate)
        {
            using (var conn = GetOpenConnection())
            {
                var existingEntity = await FindAsync(entityToUpdate.CommunityID);

                var sql = "UPDATE Communities "
                    + "SET ";

                var parameters = new DynamicParameters();
                if (existingEntity.FirstName != entityToUpdate.FirstName)
                {
                    sql += "FirstName=@FirstFirstName,LastName=@LastName";
                    parameters.Add("@FirstFirstName", entityToUpdate.FirstName, DbType.String);
                }

                sql = sql.TrimEnd(',');

                sql += " WHERE CommunityID=@CommunityID";
                parameters.Add("@CommunityID", entityToUpdate.CommunityID, DbType.Int32);

                await conn.QueryAsync(sql, parameters);
            }
        }

        public Task<bool> MyCustomRepositoryMethodExampleAsync()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

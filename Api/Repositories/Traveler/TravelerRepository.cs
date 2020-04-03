using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayer;

namespace Api
{
    public class TravelerRepository : SqlRepository<Traveler>, ITravelerRepository
    {
        private const string delete = "DELETE FROM Travelers WHERE TravelerID = @TravelerID";

        public TravelerRepository(string connectionString) : base(connectionString) { }

        public override async void DeleteAsync(int TravelerID)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = delete;
                var parameters = new DynamicParameters();
                parameters.Add("@TravelerID", TravelerID, System.Data.DbType.Int32);
                await conn.QueryFirstOrDefaultAsync<Traveler>(sql, parameters);
            }
        }

        public override async Task<IEnumerable<Traveler>> GetAllAsync()
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "SELECT * FROM Travelers";
                return await conn.QueryAsync<Traveler>(sql);
            }
        }

        public override async Task<Traveler> FindAsync(int id)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "SELECT * FROM Travelers WHERE TravelerID = @TravelerID";
                var parameters = new DynamicParameters();
                parameters.Add("@TravelerID", id, System.Data.DbType.Int32);
                return await conn.QueryFirstOrDefaultAsync<Traveler>(sql, parameters);
            }
        }

        public override async void InsertAsync(Traveler entity)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "INSERT INTO Travelers(FirstName)"
                    + "VALUES(@FirstName)";

                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", entity.FirstName, System.Data.DbType.String);

                await conn.QueryAsync(sql, parameters);
            }
        }

        public override async void UpdateAsync(Traveler entityToUpdate)
        {
            using (var conn = GetOpenConnection())
            {
                var existingEntity = await FindAsync(entityToUpdate.TravelerID);

                var sql = "UPDATE Travelers "
                    + "SET ";

                var parameters = new DynamicParameters();
                if (existingEntity.FirstName != entityToUpdate.FirstName)
                {
                    sql += "FirstName=@FirstFirstName,";
                    parameters.Add("@FirstFirstName", entityToUpdate.FirstName, DbType.String);
                }

                sql = sql.TrimEnd(',');

                sql += " WHERE Id=@Id";
                parameters.Add("@Id", entityToUpdate.TravelerID, DbType.Int32);

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

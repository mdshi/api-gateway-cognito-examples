using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayer;

namespace Api
{
    public class MedicalRepository : SqlRepository<Community>, IMedicalCenterRepository
    {
        public MedicalRepository (string connectionString) : base(connectionString) { }

        public override async void DeleteAsync(int id)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "DELETE FROM Communities WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id, System.Data.DbType.Int32);
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
                var sql = "SELECT * FROM Communities WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id, System.Data.DbType.Int32);
                return await conn.QueryFirstOrDefaultAsync<Community>(sql, parameters);
            }
        }

        public override async void InsertAsync(Community entity)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "INSERT INTO Communities(FirstName)"
                    + "VALUES(@FirstName)";

                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", entity.FirstName, System.Data.DbType.String);

                await conn.QueryAsync(sql, parameters);
            }
        }

        public override async void UpdateAsync(Community entityToUpdate)
        {
            using (var conn = GetOpenConnection())
            {
                var existingEntity = await FindAsync(entityToUpdate.Id);

                var sql = "UPDATE Communities "
                    + "SET ";

                var parameters = new DynamicParameters();
                if (existingEntity.FirstName != entityToUpdate.FirstName)
                {
                    sql += "FirstName=@FirstFirstName,";
                    parameters.Add("@FirstFirstName", entityToUpdate.FirstName, DbType.String);
                }

                sql = sql.TrimEnd(',');

                sql += " WHERE Id=@Id";
                parameters.Add("@Id", entityToUpdate.MedicalID, DbType.Int32);

                await conn.QueryAsync(sql, parameters);
            }
        }

        public Task<bool> MyCustomRepositoryMethodExampleAsync()
        {
            throw new NotImplementedException();
        }
    }
}

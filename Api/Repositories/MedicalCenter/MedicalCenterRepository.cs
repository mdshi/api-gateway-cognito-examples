using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayer;

namespace Api
{
    public class MedicalCenterRepository : SqlRepository<MedicalCenter>, IMedicalCenterRepository
    {
        public MedicalCenterRepository (string connectionString) : base(connectionString) { }

        public override async void DeleteAsync(int MedicalID)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "DELETE FROM MedicalCenters WHERE MedicalID = @MedicalID";
                var parameters = new DynamicParameters();
                parameters.Add("@MedicalID", MedicalID, System.Data.DbType.Int32);
                await conn.QueryFirstOrDefaultAsync<MedicalCenter>(sql, parameters);
            }
        }

        public override async Task<IEnumerable<MedicalCenter>> GetAllAsync()
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "SELECT * FROM MedicalCenters";
                return await conn.QueryAsync<MedicalCenter>(sql);
            }
        }

        public override async Task<MedicalCenter> FindAsync(int id)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "SELECT * FROM MedicalCenters WHERE MedicalID = @MedicalID";
                var parameters = new DynamicParameters();
                parameters.Add("@MedicalID", id, System.Data.DbType.Int32);
                return await conn.QueryFirstOrDefaultAsync<MedicalCenter>(sql, parameters);
            }
        }

        public override async void InsertAsync(MedicalCenter entity)
        {
            using (var conn = GetOpenConnection())
            {
                var sql = "INSERT INTO MedicalCenters(FirstName)"
                    + "VALUES(@FirstName)";

                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", entity.FirstName, System.Data.DbType.String);

                await conn.QueryAsync(sql, parameters);
            }
        }

        public override async void UpdateAsync(MedicalCenter entityToUpdate)
        {
            using (var conn = GetOpenConnection())
            {
                var existingEntity = await FindAsync(entityToUpdate.MedicalID);

                var sql = "UPDATE MedicalCenters "
                    + "SET ";

                var parameters = new DynamicParameters();
                if (existingEntity.FirstName != entityToUpdate.FirstName)
                {
                    sql += "FirstName=@FirstFirstName,";
                    parameters.Add("@FirstFirstName", entityToUpdate.FirstName, DbType.String);
                }

                sql = sql.TrimEnd(',');

                sql += " WHERE MedicalID=@MedicalID";
                parameters.Add("@MedicalID", entityToUpdate.MedicalID, DbType.Int32);

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

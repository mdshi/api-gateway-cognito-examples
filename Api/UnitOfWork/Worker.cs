using System;
using Microsoft.Data.SqlClient;


namespace Api.UnitOfWork
{
    public class Worker : IWorker
    {
        public void ExecuteCommand(string connectionStr, Action<SqlConnection> task)
        {
            using (var connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                task(connection);
            }
        }
        public T ExecuteCommand<T>(string connectionStr, Func<SqlConnection, T> task)
        {
            using (var connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                return task(connection);
            }
        }
    }
}

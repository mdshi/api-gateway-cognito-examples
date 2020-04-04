using System;
using Microsoft.Data.SqlClient;

namespace Api.UnitOfWork
{
    public interface IWorker
    {
        void ExecuteCommand(string connectionStr, Action<SqlConnection> task);
        T ExecuteCommand<T>(string connectionStr, Func<SqlConnection, T> task);
    }
}
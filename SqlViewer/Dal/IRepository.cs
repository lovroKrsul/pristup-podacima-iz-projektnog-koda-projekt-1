using System.Collections.Generic;
using System.Data;
using Zadatak.Models;
using System.Data.SqlClient;

namespace Zadatak.Dal
{
    interface IRepository
    {
        DataSet CreateDataSet(DBEntity dbEntity);
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType entityType);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);

        SqlConnection getCon();
        void setCon(SqlConnection con);
        void LogIn(string server, string username, string password);
    }
}
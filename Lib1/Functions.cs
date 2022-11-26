using System.Data.SQLite;
using System.Data;

namespace Lib1
{
    public static class MyFunctions
    {
        static readonly SQLiteConnection _connection;

        static MyFunctions()
        {
            _connection = new SQLiteConnection("DataSource=:memory:");
            _connection.Open();
        }

        public static object SQLiteEvaluate(string sqlCommand)
        {
            try
            {
                SQLiteCommand cmd = _connection.CreateCommand();
                cmd.CommandText = sqlCommand;
                var result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

    }
}
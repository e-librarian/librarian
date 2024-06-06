using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_register
{
    public static partial class DBHandler
    {
        private static readonly string connectionString = "Host=dpg-cp3nb4021fec73bb1ib0-a.frankfurt-postgres.render.com;Port=5432;Database=korribandb;Username=korr_user;Password=1N2F6ODSpntuDaspz4a4oDJ3A0vGMoMK;Trust Server Certificate=true;";

        public static NpgsqlConnection OpenConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static NpgsqlCommand GetCommand(NpgsqlConnection connection)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            return command;
        }

        public static void CloseConnection(NpgsqlConnection connection, NpgsqlCommand command)
        {
            command.Dispose();
            connection.Close();
        }
    }
}

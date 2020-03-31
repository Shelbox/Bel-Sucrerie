using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace ConsoleSQL
{
    class MySQL
    {

        string _connectionString = "Server=127.0.0.1; Database=sucrerie; UID=root; Pwd=";
        MySqlConnection connection = new MySqlConnection(_connectionString);
        connection.Open();
    }
}

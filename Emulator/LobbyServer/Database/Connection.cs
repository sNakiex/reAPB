﻿using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;

namespace LobbyServer.Database
{
    class Connection
    {
        public static MySqlConnection Instance
        {
            get
            {
                if (connection == null) 
                    if (connectionString == null) 
                        throw new ArgumentNullException("connectionString");
                    else
                    {
                        connection = new MySqlConnection(connectionString);
                        connection.Open();
                    }
                return connection;
            }
        }

        public static String connectionString = null;
        private static MySqlConnection connection = null;
    }
}

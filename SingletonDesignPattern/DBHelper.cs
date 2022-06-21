using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern1.SingletonDesignPattern
{
    class DBHelper
    {
        public string ConnectionString { get; set; }

        private DBHelper(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private static DBHelper _help;

        public static DBHelper CreateDBHelper(string connectionString)
        {
            if (_help == null)
            {
                _help = new DBHelper(connectionString);
            }
            return _help;
        }
        public string StateMessage { get; set; }
    }
}

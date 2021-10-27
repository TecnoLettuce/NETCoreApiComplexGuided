using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Data
{
    public class MySQLConfiguration
    {

        public string _connectionString { get; set; }

        public MySQLConfiguration(string connectionString) {
            _connectionString = connectionString;
        }
    }
}

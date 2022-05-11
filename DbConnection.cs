using System;

namespace PolymorphismExercise
{
    public class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}

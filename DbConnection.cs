using System;

namespace PolymorphismExercise
{
    public abstract class DbConnection
    {
        private string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _connectionString = value;
                }
                else
                {
                    throw new ArgumentNullException("Cannot be null or empty");
                }
            }
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}

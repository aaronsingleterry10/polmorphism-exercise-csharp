using System;

namespace PolymorphismExercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection closed.");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connection opened.");
        }
    }
}

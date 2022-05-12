using System;

namespace PolymorphismExercise
{
    public class DbCommand
    {
        private string _dbInstruction;
        private DbConnection _dbConnection;
        public DbCommand(string instruction, DbConnection dbConnection)
        {
            _dbInstruction = instruction;
            if (dbConnection != null)
            {
                _dbConnection = dbConnection;
            }
            else
            {
                throw new System.Exception("Cannot be null");
            }
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_dbInstruction);
            _dbConnection.CloseConnection();
        }
    }
}

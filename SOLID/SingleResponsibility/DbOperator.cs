using System.Data.SqlClient;

namespace SingleResponsibility
{
    public class DbOperator
    {
        private SqlConnection sqlConnection = null;
        public DbOperator(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);

        }

        public int Execute(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand command = createCommand(commandText, parameters);
            command.Connection.Open();
            var affectedRows = command.ExecuteNonQuery();
            command.Connection.Close();
            return affectedRows;
        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = commandText;
            addParametersToCommand(command, parameters);
            return command;
        }

        private void addParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }
    }
}

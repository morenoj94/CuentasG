using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class DataAccess
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }
        public DataAccess()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; database=ElGuisoDB; integrated security=true");
            command = new SqlCommand();
        }
        public void setQuery(string query)
        {
            // se declara el tipo de comando y se establece que sera la consulta que recibimos por parametro
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }
        public void executeRead()
        {
            // se asocia la coneccion a la base de datos con el comando
            command.Connection = connection;
            // en un bloque try catch se abre la coneccion y se ejecuta la lectura guardandola dentro del reader
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void executeAction()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void setParameters(string name, object value)
        {
            command.Parameters.AddWithValue(name, value);
        }

        public void closeConnection()
        {
            if (reader != null)
            {
                reader.Close();
            }
            connection?.Close(); //el operador ? sirve para consultar si conection!=null es otra forma de escribir el if de arriba
        }

    }
}

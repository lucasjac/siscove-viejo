using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SISCOVE___Todo_Envase
{
    public class Password
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable TableData = new DataTable();

        public void Save(string password, int code)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("INSERT INTO Password (PASSWORD, CODE)");
                    sql.Append("VALUES (@PASSWORD, @CODE)");

                    commandSql.Parameters.Add(new SqlParameter("@PASSWORD", password));
                    commandSql.Parameters.Add(new SqlParameter("@CODE", code));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método SAVE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void Modify(int code, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("UPDATE Password");
                    sql.Append(" SET PASSWORD = @password");
                    sql.Append(" Where (CODE = @code)");

                    commandSql.Parameters.Add(new SqlParameter("@code", code));
                    commandSql.Parameters.Add(new SqlParameter("@password", password));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método SAVE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public DataTable Login(int code, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT * FROM Password");
                    sql.Append(" WHERE CODE = @code AND PASSWORD = @password");

                    commandSql.Parameters.Add(new SqlParameter("@code", code));
                    commandSql.Parameters.Add(new SqlParameter("@password", password));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    TableData.Load(commandSql.ExecuteReader());
                    return TableData;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método LOGIN. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }
    }
}

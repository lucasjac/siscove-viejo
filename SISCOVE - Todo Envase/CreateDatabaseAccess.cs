using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SISCOVE___Todo_Envase
{
    public class CreateDatabaseAccess
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable newDataTable = new DataTable();

        public DataTable CheckDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Server= localhost\SQLEXPRESS; database=master; Integrated Security=SSPI"))
                {
                    connection.Open();

                    sql.Append("SELECT * FROM sys.databases WHERE name = 'SISCOVE'");

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    return newDataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método CHECKDATABASE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void CreateDatabase(string ScriptDatabaseSISCOVE, string ScriptTablesSISCOVE)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Server= localhost\SQLEXPRESS; Integrated Security = SSPI"))
                {
                    connection.Open();

                    sql.Append(ScriptDatabaseSISCOVE);

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();

                    sql.Clear();

                    sql.Append(ScriptTablesSISCOVE);

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método CREATEDATABASE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void CreatePassword()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("INSERT INTO Password VALUES ('c5b2cebf15b205503560c4e8e6d1ea78', '0')");

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método CREATEPASSWORD. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SISCOVE___Todo_Envase
{
    public class Orders
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable newDataTable = new DataTable();

        public void Save(int code, string product, string customer, int quantity, int situation, DateTime date)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("INSERT INTO Orders (PRODUCT, CUSTOMER, QUANTITY, SITUATION, DATE)");
                    sql.Append("VALUES (@PRODUCT, @CUSTOMER, @QUANTITY, @SITUATION, @DATE)");

                    commandSql.Parameters.Add(new SqlParameter("@PRODUCT", product));
                    commandSql.Parameters.Add(new SqlParameter("@CUSTOMER", customer));
                    commandSql.Parameters.Add(new SqlParameter("@QUANTITY", quantity));
                    commandSql.Parameters.Add(new SqlParameter("@SITUATION", situation));
                    commandSql.Parameters.Add(new SqlParameter("@DATE", date));

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

        public void Modify(int code, string product, string customer, int quantity, int situation, DateTime date)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("UPDATE Orders");
                    sql.Append(" SET PRODUCT = @product, CUSTOMER = @customer, QUANTITY = @quantity, SITUATION = @situation, DATE = @date");
                    sql.Append(" Where (ID_ORDERS = @code)");

                    commandSql.Parameters.Add(new SqlParameter("@code", code));
                    commandSql.Parameters.Add(new SqlParameter("@product", product));
                    commandSql.Parameters.Add(new SqlParameter("@customer", customer));
                    commandSql.Parameters.Add(new SqlParameter("@quantity", quantity));
                    commandSql.Parameters.Add(new SqlParameter("@situation", situation));
                    commandSql.Parameters.Add(new SqlParameter("@date", date));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método MODIFY. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void Delete(int code)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append(" DELETE FROM Orders");
                    sql.Append(" WHERE (ID_ORDERS = @code)");

                    commandSql.Parameters.Add(new SqlParameter("@code", code));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método DELETE. Si el problema persiste entre en contacto con el Administrador del Sistema."); ;
            }
        }

        public DataTable Search(string customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT * FROM Orders");
                    sql.Append(" WHERE (CUSTOMER LIKE '%'+@customer+'%')");
                    sql.Append(" ORDER BY SITUATION ASC, ID_ORDERS DESC");

                    commandSql.Parameters.Add(new SqlParameter("@customer", customer));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    return newDataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método SEARCH. Si el problema persiste entre en contacto con el Administrador del Sistema."); ;
            }
        }

        public DataTable ToList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();
                    sql.Append("SELECT *FROM Orders");
                    sql.Append(" ORDER BY SITUATION ASC, ID_ORDERS DESC");

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    return newDataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método TOLIST. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public DataTable Search2(string customer, int situation)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT * FROM Orders");
                    sql.Append(" WHERE (CUSTOMER LIKE '%'+@customer+'%') AND (SITUATION LIKE @situation)");
                    sql.Append(" ORDER BY ID_ORDERS DESC, ID_ORDERS DESC");

                    commandSql.Parameters.Add(new SqlParameter("@customer", customer));
                    commandSql.Parameters.Add(new SqlParameter("@situation", situation));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    return newDataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método SEARCH2. Si el problema persiste entre en contacto con el Administrador del Sistema."); ;
            }
        }
    }
}

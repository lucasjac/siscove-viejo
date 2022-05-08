using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SISCOVE___Todo_Envase
{
     public class Sales
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable newDataTable = new DataTable();

        public void Save(int code, int codestock, int quantity, DateTime date, int f, int price)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("INSERT INTO Sales (ID_STOCK, QUANTITY, DATE, F, PRICE)");
                    sql.Append("VALUES (@codestock, @quantity, @date, @f, @price)");

                    commandSql.Parameters.Add(new SqlParameter("@codestock", codestock));
                    commandSql.Parameters.Add(new SqlParameter("@quantity", quantity));
                    commandSql.Parameters.Add(new SqlParameter("@date", date));
                    commandSql.Parameters.Add(new SqlParameter("@f", f));
                    commandSql.Parameters.Add(new SqlParameter("@price", price));

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

        public void Modify(int code, int codestock, int quantity, DateTime date, int f, int price)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("UPDATE Sales");
                    sql.Append(" SET ID_STOCK = @codestock, QUANTITY = @quantity, DATE = @date, F = @f, PRICE = @price");
                    sql.Append(" WHERE (ID_SALES = @code)");

                    commandSql.Parameters.Add(new SqlParameter("@code", code));
                    commandSql.Parameters.Add(new SqlParameter("@codestock", codestock));
                    commandSql.Parameters.Add(new SqlParameter("@quantity", quantity));
                    commandSql.Parameters.Add(new SqlParameter("@date", date));
                    commandSql.Parameters.Add(new SqlParameter("@f", f));
                    commandSql.Parameters.Add(new SqlParameter("@price", price));

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

                    sql.Append(" DELETE FROM Sales");
                    sql.Append(" WHERE (ID_SALES = @code)");

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

        public DataTable Search(DateTime date)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT Sales.ID_SALES, Sales.ID_STOCK, Sales.QUANTITY, Sales.DATE, Sales.F, Sales.PRICE, Stock.PRODUCT ");
                    sql.Append("FROM (Sales INNER JOIN Stock ON Sales.ID_STOCK = Stock.ID_STOCK)");
                    sql.Append("WHERE (Sales.DATE = @date)");
                    sql.Append(" ORDER BY Sales.DATE DESC, Sales.ID_SALES DESC");

                    commandSql.Parameters.Add(new SqlParameter("@date", date));

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

        public DataTable SearchRecords(string product, DateTime since, DateTime until)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT Sales.ID_SALES, Sales.ID_STOCK, Sales.QUANTITY, Sales.DATE, Sales.F, Sales.PRICE, Stock.PRODUCT ");
                    sql.Append("FROM (Sales INNER JOIN Stock ON Sales.ID_STOCK = Stock.ID_STOCK)");
                    sql.Append(" WHERE (Stock.PRODUCT = @product) AND (Sales.Date >= @since) AND (Sales.Date <= @until)");
                    sql.Append(" ORDER BY Sales.DATE DESC, Sales.ID_SALES DESC");

                    commandSql.Parameters.Add(new SqlParameter("@product", product));
                    commandSql.Parameters.Add(new SqlParameter("@since", since));
                    commandSql.Parameters.Add(new SqlParameter("@until", until));

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

        public DataTable SearchRecords2(DateTime since, DateTime until)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT Sales.ID_SALES, Sales.ID_STOCK, Sales.QUANTITY, Sales.DATE, Sales.F, Sales.PRICE, Stock.PRODUCT ");
                    sql.Append("FROM (Sales INNER JOIN Stock ON Sales.ID_STOCK = Stock.ID_STOCK)");
                    sql.Append(" WHERE (Sales.Date >= @since) AND (Sales.Date <= @until)");
                    sql.Append(" ORDER BY Sales.DATE DESC, Sales.ID_SALES DESC");

                    commandSql.Parameters.Add(new SqlParameter("@since", since));
                    commandSql.Parameters.Add(new SqlParameter("@until", until));

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

        public DataTable SearchRecords3(string product, DateTime since, DateTime until, int f)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT Sales.ID_SALES, Sales.ID_STOCK, Sales.QUANTITY, Sales.DATE, Sales.F, Sales.PRICE, Stock.PRODUCT ");
                    sql.Append("FROM (Sales INNER JOIN Stock ON Sales.ID_STOCK = Stock.ID_STOCK)");
                    sql.Append(" WHERE (Stock.PRODUCT = @product) AND (Sales.Date >= @since) AND (Sales.Date <= @until) AND (Sales.F = @f)");
                    sql.Append(" ORDER BY Sales.DATE DESC, Sales.ID_SALES DESC");

                    commandSql.Parameters.Add(new SqlParameter("@product", product));
                    commandSql.Parameters.Add(new SqlParameter("@since", since));
                    commandSql.Parameters.Add(new SqlParameter("@until", until));
                    commandSql.Parameters.Add(new SqlParameter("@f", f));

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

        public DataTable Search2(int code)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT Sales.ID_SALES, Sales.ID_STOCK, Sales.QUANTITY, Sales.DATE, Sales.F, Sales.PRICE, Stock.PRODUCT ");
                    sql.Append("FROM (Sales INNER JOIN Stock ON Sales.ID_STOCK = Stock.ID_STOCK)");
                    sql.Append("WHERE (Sales.ID_SALES = @code)");
                    sql.Append(" ORDER BY Sales.DATE DESC, Sales.ID_SALES DESC");

                    commandSql.Parameters.Add(new SqlParameter("@code", code));

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

                    sql.Append("SELECT Sales.ID_SALES, Sales.ID_STOCK, Sales.QUANTITY, Sales.DATE, Sales.F, Sales.PRICE, Stock.PRODUCT ");
                    sql.Append("FROM (Sales INNER JOIN Stock ON Sales.ID_STOCK = Stock.ID_STOCK)");
                    sql.Append(" ORDER BY Sales.DATE DESC, Sales.ID_SALES DESC");

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

        public int ReturnSale(int codesale)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT QUANTITY FROM Sales");
                    sql.Append(" WHERE (ID_SALES = @codesale)");

                    commandSql.Parameters.Add(new SqlParameter("@codesale", codesale));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    int QuantitySale = (Int32)commandSql.ExecuteScalar();
                    return QuantitySale;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método RETURNSALE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }
    }
}

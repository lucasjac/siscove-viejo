using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SISCOVE___Todo_Envase
{
    public class Stock
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable newDataTable = new DataTable();

        public void Save(int code, string product, int price1, int price2, int price3, int quantity, int warning)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("INSERT INTO Stock (PRODUCT, PRICE1, PRICE2, PRICE3, QUANTITY, WARNING)");
                    sql.Append("VALUES (@product, @saleprice1, @saleprice2, @saleprice3, @quantity, @warning)");

                    commandSql.Parameters.Add(new SqlParameter("@product", product));
                    commandSql.Parameters.Add(new SqlParameter("@saleprice1", price1));
                    commandSql.Parameters.Add(new SqlParameter("@saleprice2", price2));
                    commandSql.Parameters.Add(new SqlParameter("@saleprice3", price3));
                    commandSql.Parameters.Add(new SqlParameter("@quantity", quantity));
                    commandSql.Parameters.Add(new SqlParameter("@warning", warning));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception ("Ocurrió un error en el método SAVE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void Modify(int code, string product, int price1, int price2, int price3, int quantity, int warning)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("UPDATE Stock");
                    sql.Append(" SET PRODUCT = @product, PRICE1 = @price1, PRICE2 = @price2, PRICE3 = @price3, QUANTITY = @quantity, WARNING = @warning");
                    sql.Append(" WHERE (ID_STOCK = @code)");

                    commandSql.Parameters.Add(new SqlParameter("@code", code));
                    commandSql.Parameters.Add(new SqlParameter("@product", product));
                    commandSql.Parameters.Add(new SqlParameter("@price1", price1));
                    commandSql.Parameters.Add(new SqlParameter("@price2", price2));
                    commandSql.Parameters.Add(new SqlParameter("@price3", price3));
                    commandSql.Parameters.Add(new SqlParameter("@quantity", quantity));
                    commandSql.Parameters.Add(new SqlParameter("@warning", warning));

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

                    sql.Append(" DELETE FROM Stock");
                    sql.Append(" WHERE (ID_STOCK = @code)");

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

        public DataTable Search(string product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT * FROM Stock");
                    sql.Append(" WHERE (PRODUCT LIKE '%'+@product+'%')");
                    sql.Append(" ORDER BY PRODUCT ASC");

                    commandSql.Parameters.Add(new SqlParameter("@product", product));

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

        public DataTable Search2(string product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT * FROM Stock");
                    sql.Append(" WHERE (PRODUCT LIKE '%'+@product+'%')");
                    sql.Append(" ORDER BY QUANTITY ASC");

                    commandSql.Parameters.Add(new SqlParameter("@product", product));

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
                    sql.Append("SELECT * FROM Stock");
                    sql.Append(" ORDER BY PRODUCT ASC");

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

        public DataTable ToList2()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();
                    sql.Append("SELECT * FROM Stock");
                    sql.Append(" ORDER BY QUANTITY ASC");

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

        public int ReturnStock(int codeproduct)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT QUANTITY FROM Stock");
                    sql.Append(" WHERE (ID_STOCK = @codeproduct)");

                    commandSql.Parameters.Add(new SqlParameter("@codeproduct", codeproduct));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    int StockProduct = (Int32)commandSql.ExecuteScalar();
                    return StockProduct;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método RETURNSTOCK. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void UpdateStock(int idstock, int quantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("UPDATE Stock");
                    sql.Append(" SET QUANTITY = @quantity");
                    sql.Append(" WHERE (ID_STOCK = @idstock)");

                    commandSql.Parameters.Add(new SqlParameter("@idstock", idstock));
                    commandSql.Parameters.Add(new SqlParameter("@quantity", quantity));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método UPDATESTOCK. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public int ReturnPrice1(int codeproduct)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT PRICE1, ID_STOCK FROM Stock");
                    sql.Append(" WHERE (ID_STOCK = @codeproduct)");

                    commandSql.Parameters.Add(new SqlParameter("@codeproduct", codeproduct));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    int PriceProduct = (Int32)commandSql.ExecuteScalar();
                    return PriceProduct;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método RETURNPRICE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public int ReturnPrice2(int codeproduct)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT PRICE2, ID_STOCK FROM Stock");
                    sql.Append(" WHERE (ID_STOCK = @codeproduct)");

                    commandSql.Parameters.Add(new SqlParameter("@codeproduct", codeproduct));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    int PriceProduct = (Int32)commandSql.ExecuteScalar();
                    return PriceProduct;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método RETURNPRICE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public int ReturnPrice3(int codeproduct)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT PRICE3, ID_STOCK FROM Stock");
                    sql.Append(" WHERE (ID_STOCK = @codeproduct)");

                    commandSql.Parameters.Add(new SqlParameter("@codeproduct", codeproduct));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    int PriceProduct = (Int32)commandSql.ExecuteScalar();
                    return PriceProduct;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método RETURNPRICE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }
    }
}

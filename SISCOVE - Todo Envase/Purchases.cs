using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SISCOVE___Todo_Envase
{
    public class Purchases
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable newDataTable = new DataTable();

        public void Save(int code, int codestock, int codedistributor, int price, int quantity, DateTime date, int f)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("INSERT INTO Purchases (ID_STOCK, ID_DISTRIBUTORS, PRICE, QUANTITY, DATE, F)");
                    sql.Append("VALUES (@codestock, @codedistributor, @price, @quantity, @date, @f)");

                    commandSql.Parameters.Add(new SqlParameter("@codestock", codestock));
                    commandSql.Parameters.Add(new SqlParameter("@codedistributor", codedistributor));
                    commandSql.Parameters.Add(new SqlParameter("@price", price));
                    commandSql.Parameters.Add(new SqlParameter("@quantity", quantity));
                    commandSql.Parameters.Add(new SqlParameter("@date", date));
                    commandSql.Parameters.Add(new SqlParameter("@f", f));

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

        public void Modify(int code, int codestock, int codedistributor, int price, int quantity, DateTime date, int f)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("UPDATE Purchases");
                    sql.Append(" SET ID_STOCK = @codestock, ID_DISTRIBUTORS = @codedistributor, PRICE = @price, QUANTITY = @quantity, DATE = @date, F = @f");
                    sql.Append(" Where (ID_PURCHASES = @code)");

                    commandSql.Parameters.Add(new SqlParameter("@code", code));
                    commandSql.Parameters.Add(new SqlParameter("@codestock", codestock));
                    commandSql.Parameters.Add(new SqlParameter("@codedistributor", codedistributor));
                    commandSql.Parameters.Add(new SqlParameter("@price", price));
                    commandSql.Parameters.Add(new SqlParameter("@quantity", quantity));
                    commandSql.Parameters.Add(new SqlParameter("@date", date));
                    commandSql.Parameters.Add(new SqlParameter("@f", f));

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

                    sql.Append(" DELETE FROM Purchases");
                    sql.Append(" WHERE (ID_PURCHASES = @code)");

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

                    sql.Append("SELECT Purchases.ID_PURCHASES, Purchases.ID_STOCK, Purchases.ID_DISTRIBUTORS, Purchases.PRICE, Purchases.QUANTITY, Purchases.DATE, Purchases.F, Stock.PRODUCT ");
                    sql.Append("FROM Purchases INNER JOIN Stock ON Purchases.ID_STOCK = Stock.ID_STOCK ");
                    sql.Append("WHERE (Purchases.DATE = @date) ");
                    sql.Append("ORDER BY Purchases.DATE DESC, Purchases.ID_PURCHASES DESC");

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

                    sql.Append("SELECT Purchases.ID_PURCHASES, Purchases.ID_STOCK, Purchases.ID_DISTRIBUTORS, Purchases.PRICE, Purchases.QUANTITY, Purchases.DATE, Purchases.F, Stock.PRODUCT ");
                    sql.Append("FROM Purchases INNER JOIN Stock ON Purchases.ID_STOCK = Stock.ID_STOCK ");
                    sql.Append("WHERE (Stock.PRODUCT = @product) AND (Purchases.Date >= @since) AND (Purchases.Date <= @until) ");
                    sql.Append("ORDER BY Purchases.DATE DESC, Purchases.ID_PURCHASES DESC");

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

                    sql.Append("SELECT Purchases.ID_PURCHASES, Purchases.ID_STOCK, Purchases.ID_DISTRIBUTORS, Purchases.PRICE, Purchases.QUANTITY, Purchases.DATE, Purchases.F, Stock.PRODUCT ");
                    sql.Append("FROM Purchases INNER JOIN Stock ON Purchases.ID_STOCK = Stock.ID_STOCK ");
                    sql.Append("WHERE (Purchases.Date >= @since) AND (Purchases.Date <= @until) ");
                    sql.Append("ORDER BY Purchases.DATE DESC, Purchases.ID_PURCHASES DESC");

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

        public DataTable ToList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT Purchases.ID_PURCHASES, Purchases.ID_STOCK, Purchases.ID_DISTRIBUTORS, Purchases.PRICE, Purchases.QUANTITY, Purchases.DATE, Purchases.F, Stock.PRODUCT ");
                    sql.Append("FROM Purchases INNER JOIN Stock ON Purchases.ID_STOCK = Stock.ID_STOCK ");
                    sql.Append("ORDER BY Purchases.DATE DESC, Purchases.ID_PURCHASES DESC");
                    
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

        public int ReturnPurchase(int codepurchase)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT QUANTITY FROM Purchases");
                    sql.Append(" WHERE (ID_PURCHASES = @codepurchase)");

                    commandSql.Parameters.Add(new SqlParameter("@codepurchase", codepurchase));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    int QuantityPurchase = (Int32)commandSql.ExecuteScalar();
                    return QuantityPurchase;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método RETURNSALE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public int ReturnPrice(int codedistributor, int codestock)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT PRICE, ID_PURCHASES, ID_STOCK, ID_DISTRIBUTORS, DATE ");
                    sql.Append("FROM Purchases");
                    sql.Append(" WHERE (ID_DISTRIBUTORS = @codedistributor) AND (ID_STOCK = @codestock) ");
                    sql.Append("ORDER BY DATE DESC");

                    commandSql.Parameters.Add(new SqlParameter("@codedistributor", codedistributor));
                    commandSql.Parameters.Add(new SqlParameter("@codestock", codestock));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    int PricePurchase = (Int32)commandSql.ExecuteScalar();
                    return PricePurchase;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método RETURNPRICE. Si el problema persiste entre en contacto con el Administrador del Sistema."); ;
            }
        }
    }
}

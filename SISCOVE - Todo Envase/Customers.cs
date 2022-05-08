﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SISCOVE___Todo_Envase
{
    public class Customers
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable newDataTable = new DataTable();

        public void Save(string name, string tel1, string tel2, string tel3, string ruc)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("INSERT INTO Customers (NAME, TEL1, TEL2, TEL3, RUC)");
                    sql.Append("VALUES (@NAME, @TEL1, @TEL2, @TEL3, @RUC)");

                    commandSql.Parameters.Add(new SqlParameter("@NAME", name));
                    commandSql.Parameters.Add(new SqlParameter("@TEL1", tel1));
                    commandSql.Parameters.Add(new SqlParameter("@TEL2", tel2));
                    commandSql.Parameters.Add(new SqlParameter("@TEL3", tel3));
                    commandSql.Parameters.Add(new SqlParameter("@RUC", ruc));

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

        public void Modify(int code, string name, string tel1, string tel2, string tel3, string ruc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("UPDATE Customers");
                    sql.Append(" SET NAME = @name, TEL1 = @tel1, TEL2 = @tel2, TEL3 = @tel3, RUC = @ruc");
                    sql.Append(" Where (ID_CUSTOMERS = @code)");

                    commandSql.Parameters.Add(new SqlParameter("@code", code));
                    commandSql.Parameters.Add(new SqlParameter("@name", name));
                    commandSql.Parameters.Add(new SqlParameter("@tel1", tel1));
                    commandSql.Parameters.Add(new SqlParameter("@tel2", tel2));
                    commandSql.Parameters.Add(new SqlParameter("@tel3", tel3));
                    commandSql.Parameters.Add(new SqlParameter("@ruc", ruc));

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

                    sql.Append(" DELETE FROM Customers");
                    sql.Append(" WHERE (ID_CUSTOMERS = @code)");

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
        
        public DataTable Search(string name)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT * FROM Customers");
                    sql.Append(" WHERE (NAME LIKE '%'+@name+'%')");
                    sql.Append(" ORDER BY NAME ASC");

                    commandSql.Parameters.Add(new SqlParameter("@name", name));

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
                    sql.Append("SELECT *FROM Customers");
                    sql.Append(" ORDER BY NAME ASC");

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
    }
}

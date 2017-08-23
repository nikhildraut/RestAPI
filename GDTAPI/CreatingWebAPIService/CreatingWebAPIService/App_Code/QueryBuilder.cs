using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DevetchAPI
{
    public class QueryBuilder
    {
        #region Static Vars
        //static MySqlConnection sqlConn = new MySqlConnection();
        //static MySqlCommand sqlCmd = new MySqlCommand();
        #endregion

        #region Query Methods

        public static string GetStr(string Column, string TableName, string WhereClause)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                //sqlConn.Close();
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select " + Column.Trim() + " from " + TableName.Trim() + " " + WhereClause.Trim();
                string ReturnValue = sqlCmd.ExecuteScalar().ToString();
                sqlConn.Close();
                return ReturnValue;
            }
            catch (Exception ex)
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return string.Empty;
            }
            finally { }
        }

        public static Int32 GetInt(string Column, string TableName, string WhereClause)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                //sqlConn.Close();
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select " + Column.Trim() + " from " + TableName.Trim() + " " + WhereClause.Trim();
                Int32 ReturnValue = Convert.ToInt32(sqlCmd.ExecuteScalar()) == null ? 0 : Convert.ToInt32(sqlCmd.ExecuteScalar());
                sqlConn.Close();
                return ReturnValue;
            }
            catch (Exception ex)
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return 0;
            }
            finally { }
        }

        public static Int64 GetInt64(string Column, string TableName, string WhereClause)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                //sqlConn.Close();
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select " + Column.Trim() + " from " + TableName.Trim() + " " + WhereClause.Trim();
                Int64 ReturnValue = (Int64)sqlCmd.ExecuteScalar() == null ? 0 : (Int64)sqlCmd.ExecuteScalar();
                sqlConn.Close();
                return ReturnValue;
            }
            catch (Exception ex)
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return 0;
            }
            finally { }
        }

        public static DataTable GetDataTable(string Column, string TableName, string WhereClause)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();
                //sqlConn.Close();
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select " + Column.Trim() + " from " + TableName.Trim() + " " + WhereClause.Trim();
                da.SelectCommand = sqlCmd;
                da.Fill(ds);
                sqlConn.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                // ErrorLog.WriteErrorLog("QueryBuilder - GetDataTable - " + ex.Message.Replace("\n", "").ToString());
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return null;
            }
            finally { }
        }

        public static DataTable GetDataTable(string strQuery)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();
                //sqlConn.Close();
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strQuery;
                da.SelectCommand = sqlCmd;
                da.Fill(ds);
                sqlConn.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                // ErrorLog.WriteErrorLog("QueryBuilder - GetDataTable - " + ex.Message.Replace("\n", "").ToString());
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return null;
            }
            finally { }
        }

        public static string GetStrKill(string strQuery)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
               
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strQuery;
                string ReturnValue = sqlCmd.ExecuteNonQuery().ToString();
                sqlConn.Close();
                return ReturnValue;

            }
            catch (Exception ex)
            {
                // ErrorLog.WriteErrorLog("QueryBuilder - GetDataTable - " + ex.Message.Replace("\n", "").ToString());
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return null;
            }
            finally { }
        }

        public static MySqlDataReader GetDataReader(string Column, string TableName, string WhereClause)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                MySqlDataReader reader;
                //sqlConn.Close();
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select " + Column.Trim() + " from " + TableName.Trim() + " " + WhereClause.Trim();
                reader = sqlCmd.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return null;
            }
            finally { }
        }

        public static bool GetIntBool(string Column, string TableName, string WhereClause, Int64 Count)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                Int64 UserId = 0;
                //sqlConn.Close();
                bool IsAuth = false;
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select " + Column.Trim() + " from " + TableName.Trim() + " " + WhereClause.Trim();
                UserId = (Int64)sqlCmd.ExecuteScalar();
                if (UserId > Count)
                {
                    IsAuth = true;
                }
                sqlConn.Close();
                return IsAuth;
            }
            catch (Exception ex)
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return false;
            }
            finally { }
        }

        public static bool InsertInDB(string TableName, string Columns, string Values)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                //sqlConn.Close();
                Int32 IsAuth = 0;
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Insert Into " + TableName.Trim() + " ( " + Columns.Trim() + " ) Values ( " + Values.Trim() + " )";
                IsAuth = sqlCmd.ExecuteNonQuery();
                if (IsAuth != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return false;
            }
            finally { }
        }

        public static bool UpdateDB(string Column, string TableName, string WhereClause)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                bool IsUpdate = false;
                //sqlConn.Close();
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Update " + TableName.Trim() + " Set " + Column.Trim() + " " + WhereClause.Trim();
                Int32 Count = sqlCmd.ExecuteNonQuery();

                if (Count != 0)
                {
                    IsUpdate = true;
                }

                sqlConn.Close();
                return IsUpdate;
            }
            catch (Exception ex)
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return false;
            }
            finally { }
        }

        public static bool DeleteData(string Column, string TableName, string WhereClause)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            try
            {
                bool IsUpdate = false;
                sqlConn.ConnectionString = Comman.ConnectionString;
                //sqlConn.Close();
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Delete From " + TableName.Trim() + " " + WhereClause.Trim();
                Int32 Count = sqlCmd.ExecuteNonQuery();

                if (Count != 0)
                {
                    IsUpdate = true;
                }

                sqlConn.Close();
                return IsUpdate;
            }
            catch (Exception ex)
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                string Error = ex.Message;
                return false;
            }
            //finally { }
        }

        public static string[] GetArrayList(string Column, string TableName, string WhereClause)
        {
            try
            {
                MySqlConnection sqlConn = new MySqlConnection();
                MySqlCommand sqlCmd = new MySqlCommand();
                DataTable ds1 = new DataTable();
                // string[] arr4 = new string[3];
                MySqlDataAdapter da = new MySqlDataAdapter();
                sqlConn.Close();
                sqlConn.ConnectionString = Comman.ConnectionString;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select " + Column.Trim() + " from " + TableName.Trim() + " " + WhereClause.Trim();
                da.SelectCommand = sqlCmd;
                da.Fill(ds1);

                int count = ds1.Rows.Count;
                //foreach(DataRow dr in ds1.Rows)
                //{
                //    ds = (dr["user_firstName"].ToString());
                //}
                string[] ds = new string[count];
                for (int i = 0; i < count; i++)
                {
                    //ds = (dr["user_firstName"].ToString());
                    ds[i] = ds1.Rows[i]["FullName"].ToString();

                }

                sqlConn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally { }
        }
        #endregion
    }
}
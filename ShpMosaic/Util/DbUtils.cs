using System;
using System.Data;
using System.Data.SQLite;

namespace ShpMosaic.Util
{
    class DbUtils
    {
        private static string connStr = "Data Source = " + Environment.CurrentDirectory + "\\db.sqlite";
        private static SQLiteConnection conn = new SQLiteConnection(connStr);

        private static bool open()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    conn.LoadExtension("mod_spatialite.dll");
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        private static void close()
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        // 查询
        public static DataTable Query(String sqlStr)
        {
            DataTable dt = new DataTable();
            if (open())
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(sqlStr, conn);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                close();
            }

            return dt;
        }

        // 查询
        public static DataTable Query(SQLiteCommand cmd)
        {
            DataTable dt = new DataTable();
            if (open())
            {
                try
                {
                    cmd.Connection = conn;
                    SQLiteDataAdapter adpt = new SQLiteDataAdapter(cmd);
                    adpt.Fill(dt);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                close();
            }

            return dt;
        }

        // 增删改
        public static int Execute(string sqlStr)
        {
            try
            {
                if (open())
                {
                    SQLiteCommand cmd = new SQLiteCommand(sqlStr, conn);
                    return cmd.ExecuteNonQuery();
                }
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return -1;
            }
            finally
            {
                close();
            }
        }

        // 增删改
        public static int Execute(SQLiteCommand cmd)
        {
            try
            {
                if (open())
                {
                    cmd.Connection = conn;
                    return cmd.ExecuteNonQuery();
                }
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return -1;
            }
            finally
            {
                close();
            }
        }
    }
}

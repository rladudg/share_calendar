using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Project_Maver.Common
{
    internal class DbManager
    {
        static string connStr = "Server=192.168.0.96;Database=maverdb;Uid=maver_admin;Pwd=moble1234;";
        static MySqlConnection conn = new MySqlConnection(connStr);


        // select로 데이터 내용이 반환되는 쿼리를 실행 할 때
        public static DataTable select_Query(string sql, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("에러!! : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }



        // insert, update, delete 등 반환이 없는 쿼리를 사용 할 때
        public static int void_query(string sql, Dictionary<string, object> parameters = null)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                return cmd.ExecuteNonQuery(); // 영향받은 행의 수 반환 (성공한 갯수)
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }

        }

    }
}

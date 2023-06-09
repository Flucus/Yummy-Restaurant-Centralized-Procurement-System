using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.CodeDom;
using System.Data;

namespace YummyRestaurantSystem
{
    public static class SQLHandler
    {
        private static readonly string connString = "server=127.0.0.1;port=3306;user id=root;password=;database=YummyRestaurantGroupDB;charset=utf8;";
        private static Random random = new Random();

        public static string GenerateSalt()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int length = 16;
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        public static DataRow CheckLogin(string acc, string password)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $"SELECT * FROM Account WHERE AccName = '{acc}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
                return null;

            DataRow response = dt.Rows[0];
            string passwordHash = (string)response["Hash"];
            string salt = (string)response["Salt"];

            SHA256Managed crypt = new SHA256Managed();
            string hash = string.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(password + salt));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }

            bool result = hash.Equals(passwordHash);
            return result ? response : null;
        }
    }
}

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

        private static string GenerateSalt()
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

        public static DataRow GetStaffData(string staffID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $"SELECT * FROM Staff WHERE StaffID = '{staffID}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
                return null;

            DataRow response = dt.Rows[0];
            return response;
        }

        public static DataRow GetRestaurantData(string locID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $"SELECT * FROM Restaurant WHERE LocID = '{locID}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
                return null;

            DataRow response = dt.Rows[0];
            return response;
        }

        public static DataTable GetRequest(string locID, string requestMatch)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $"SELECT * FROM RestaurantRequest WHERE RestaurantID = '{locID}'";
            if (requestMatch.Length > 0)
            {
                sql += $" AND RequestID LIKE '%{requestMatch}%'";
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable GetRequestItem(string requestID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $@"SELECT DISTINCT v.VirtualID, s.Name, r.Quantity
                FROM RequestItem AS r
                JOIN Item AS i ON i.ItemID = r.ItemID
                JOIN SupplierItem AS s ON s.SupplierID = i.SupplierID AND s.SupplierItemID = i.SupplierItemID
                JOIN VirtualItem AS v ON v.ItemID = i.ItemID
                WHERE RequestID = '{requestID}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataRow GetItemByRequestIDAndVID(DataRow restData, string RequestID, string VID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string typeID = (string)restData["TypeID"];
            string sql = $@"SELECT ItemID FROM VirtualItem WHERE VirtualID = '{VID}' AND TypeID = '{typeID}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
                return null;


            DataRow response = dt.Rows[0];
            string itemID = (string)response["ItemID"];

            sql = $@"SELECT s.Name, ri.Quantity FROM RestaurantRequest AS rr
                JOIN RequestItem as ri ON ri.RequestID = rr.RequestID
                JOIN Item as i ON i.ItemID = ri.ItemID
                JOIN SupplierItem as s ON s.SupplierID = i.SupplierID AND s.SupplierItemID = i.SupplierItemID
                WHERE rr.RequestID = '{RequestID}' AND i.ItemID = '{itemID}'";
            adapter = new MySqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
                return null;

            response = dt.Rows[0];
            return response;
        }

        public static DataRow GetItemByVID(string VID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $@"SELECT s.Name FROM RestaurantRequest AS rr
                JOIN Restaurant AS r ON r.LocID = rr.RestaurantID
                JOIN RestaurantType as rt ON rt.TypeID = r.TypeID
                JOIN RequestItem as ri ON ri.RequestID = rr.RequestID
                JOIN VirtualItem as v ON v.TypeID = rt.TypeID
                JOIN Item as i ON i.ItemID = v.ItemID
                JOIN SupplierItem as s ON s.SupplierID = i.SupplierID AND s.SupplierItemID = i.SupplierItemID
                WHERE v.VirtualID = '{VID}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
                return null;

            DataRow response = dt.Rows[0];
            return response;
        }

        public static void InsertItemToRequest(DataRow restData, string requestID, string VID, int quantity)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string typeID = (string)restData["TypeID"];
            string sql = $@"SELECT ItemID FROM VirtualItem WHERE VirtualID = '{VID}' AND TypeID = '{typeID}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow response = dt.Rows[0];
            string itemID = (string)response["ItemID"];

            sql = $@"INSERT INTO RequestItem VALUES ('{requestID}', '{itemID}', {quantity})";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static bool RemoveItemFromRequest(DataRow restData, string requestID, string VID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string typeID = (string)restData["TypeID"];
            string sql = $@"SELECT ItemID FROM VirtualItem WHERE VirtualID = '{VID}' AND TypeID = '{typeID}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow response = dt.Rows[0];
            string itemID = (string)response["ItemID"];

            sql = $@"DELETE FROM RequestItem WHERE RequestID = '{requestID}' AND ItemID = '{itemID}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count == 1;
        }
    }
}

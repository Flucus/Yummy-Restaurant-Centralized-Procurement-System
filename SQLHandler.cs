using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.CodeDom;
using System.Data;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Security.Claims;

namespace YummyRestaurantSystem
{
    public static class SQLHandler
    {
        private static readonly string connString = "server=127.0.0.1;port=3306;user id=root;password=;database=YummyRestaurantGroupDB;charset=utf8;convert zero datetime=True";
        private static Random random = new Random();
        private static string currentUserID = "";

        private static string GenerateSalt()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int length = 16;
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        private static void RecordActivity(string sql)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string getLast = "SELECT * FROM ActivityLog ORDER BY ActivityID DESC LIMIT 1";
            MySqlDataAdapter adapter = new MySqlDataAdapter(getLast, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow response = dt.Rows[0];
            string lastActivityID = (string)response["ActivityID"];

            int numID = int.Parse(lastActivityID.Substring(1)) + 1;
            string newID = 'A' + numID.ToString().PadLeft(9, '0');

            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string processedSql = sql.Replace("'", "\\'");

            string insertSql = $@"INSERT INTO ActivityLog (ActivityID, StaffID, SqlQuery, TIMESTAMP)
                VALUES ('{newID}', '{currentUserID}', '{processedSql}', '{currentTime}')";

            MySqlCommand cmd = new MySqlCommand(insertSql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
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
            if (result)
            {
                currentUserID = (string)response["StaffID"];
                return response;
            }
            else
            {
                return null;
            }
        }

        public static DataRow GetStaffData(string staffID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $"SELECT * FROM Staff WHERE StaffID = '{staffID}'";
            RecordActivity(sql);
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
            RecordActivity(sql);
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
            RecordActivity(sql);
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
            RecordActivity(sql);
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
            RecordActivity(sql);
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
            RecordActivity(sql);
            adapter = new MySqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
                return null;

            response = dt.Rows[0];
            return response;
        }

        public static DataRow GetItemByVIDTypeID(string VID, string typeID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $@"SELECT s.Name, i.ItemID FROM RestaurantRequest AS rr
                JOIN Restaurant AS r ON r.LocID = rr.RestaurantID
                JOIN RestaurantType as rt ON rt.TypeID = r.TypeID
                JOIN RequestItem as ri ON ri.RequestID = rr.RequestID
                JOIN VirtualItem as v ON v.TypeID = rt.TypeID
                JOIN Item as i ON i.ItemID = v.ItemID
                JOIN SupplierItem as s ON s.SupplierID = i.SupplierID AND s.SupplierItemID = i.SupplierItemID
                WHERE v.VirtualID = '{VID}' AND v.TypeID = '{typeID}'";
            RecordActivity(sql);
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
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow response = dt.Rows[0];
            string itemID = (string)response["ItemID"];

            sql = $@"INSERT INTO RequestItem VALUES ('{requestID}', '{itemID}', {quantity})";
            RecordActivity(sql);
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
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow response = dt.Rows[0];
            string itemID = (string)response["ItemID"];

            sql = $@"DELETE FROM RequestItem WHERE RequestID = '{requestID}' AND ItemID = '{itemID}'";
            RecordActivity(sql);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count == 1;
        }

        public static DataTable GetVIDMapping(string itemNameMatch, string typeNameMatch)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = @"SELECT v.VirtualID, v.TypeID, rt.TypeName, v.ItemID, si.Name, si.Category, si.Description
                FROM VirtualItem AS v
                JOIN RestaurantType AS rt ON rt.TypeID = v.TypeID
                JOIN Item AS i ON i.ItemID = v.ItemID
                JOIN SupplierItem AS si ON si.SupplierID = i.SupplierID AND si.SupplierItemID = i.SupplierItemID";
            if (itemNameMatch.Length > 0 && typeNameMatch.Length > 0)
            {
                sql += $" WHERE si.Name LIKE '%{itemNameMatch}%' AND rt.TypeName = '{typeNameMatch}'";
            }
            else if (itemNameMatch.Length > 0)
            {
                sql += $" WHERE si.Name LIKE '%{itemNameMatch}%'";
            }
            else if (typeNameMatch.Length > 0)
            {
                sql += $" WHERE rt.TypeName = '{typeNameMatch}'";
            }
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static bool DeleteVIDMapping(string VID, string typeID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $"DELETE FROM VirtualItem WHERE VirtualID = '{VID}' AND TypeID = '{typeID}'";
            RecordActivity(sql);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count == 1;
        }

        public static DataTable GetAllRestaurantType()
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = "SELECT DISTINCT TypeID, TypeName FROM RestaurantType";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static string GetItemNameByItemID(string itemID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $@"SELECT si.Name
                FROM Item AS i
                JOIN SupplierItem AS si ON si.SupplierID = i.SupplierID AND si.SupplierItemID = i.SupplierItemID
                WHERE ItemID = '{itemID}'";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string itemName = (string)dt.Rows[0]["Name"];
                return itemName;
            }
            return null;
        }
        public static string GetTypeNameByTypeID(string typeID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $"SELECT TypeName FROM RestaurantType WHERE TypeID = '{typeID}'";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string typeName = (string)dt.Rows[0]["TypeName"];
                return typeName;
            }
            return null;
        }

        public static bool CreateVIDMapping(string VID, string typeID, string itemID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $"INSERT INTO VirtualItem VALUES ('{VID}', '{typeID}', '{itemID}')";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool UpdateVIDMapping(string VID, string typeID, string itemID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $"UPDATE VirtualItem SET ItemID = '{itemID}' WHERE VirtualID = '{VID}' AND TypeID = '{typeID}'";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool CreateRestaurantRequest(DataRow staffData, DataRow restData, DataTable item, string remark)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = "SELECT * FROM RestaurantRequest ORDER BY RequestID DESC LIMIT 1";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow response = dt.Rows[0];
            string lastRequestID = (string)response["RequestID"];

            int numID = int.Parse(lastRequestID.Substring(1)) + 1;
            string newID = 'R' + numID.ToString().PadLeft(9, '0');
            string managerID = (string)staffData["StaffID"];
            string restID = (string)staffData["LocID"];
            string createDate = DateTime.Now.ToString("yyyy-MM-dd");
            string expDate = (DateTime.Now.AddDays(3)).ToString("yyyy-MM-dd");

            sql = $"INSERT INTO RestaurantRequest VALUES ('{newID}', '{managerID}', '{createDate}', '{restID}', '{expDate}', '{remark}', 'P')";
            RecordActivity(sql);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int count = cmd.ExecuteNonQuery();
            if (count == 0) return false;

            sql = "INSERT INTO RequestItem VALUES ";
            string typeID = (string)restData["TypeID"];
            foreach (DataRow row in item.Rows)
            {
                string VID = (string)row["ItemID"];
                int quantity = (int)row["Quantity"];

                DataRow res = GetItemByVIDTypeID(VID, typeID);
                if (res == null) return false;
                string itemID = (string)res["ItemID"];

                sql += $"('{newID}', '{itemID}', {quantity}), ";
            }
            sql = sql.Substring(0, sql.Length - 2);
            RecordActivity(sql);
            try
            {
                cmd = new MySqlCommand(sql, conn);
                count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static DataTable GetInventoryByLocID(string locID, string nameMatch = "")
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $@"SELECT vi.VirtualID, si.Name, iv.Count, si.Category, si.Description
                FROM Inventory AS iv
                JOIN Restaurant AS r ON r.LocID = iv.LocID
                JOIN VirtualItem AS vi ON vi.ItemID = iv.ItemID AND vi.TypeID = r.TypeID
                JOIN Item AS i ON i.ItemID = iv.ItemID
                JOIN SupplierItem AS si ON si.SupplierID = i.SupplierID AND si.SupplierItemID = i.SupplierItemID
                WHERE r.LocID = '{locID}'";
            if (nameMatch.Length > 0)
            {
                sql += $" AND si.Name LIKE '%{nameMatch}%'";
            }
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            return dt;
        }

        public static void UpdateInvCount(string locID, string itemID, int count)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();
            string sql = $"UPDATE Inventory SET Count = {count} WHERE LocID = '{locID}' AND ItemID = '{itemID}'";
            RecordActivity(sql);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable GetStaffRecord(string IDMatch = "", string nameMatch = "")
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = "SELECT * FROM Staff";
            if (IDMatch.Length > 0 && nameMatch.Length > 0)
            {
                sql += $" WHERE StaffID LIKE '%{IDMatch}%' AND Name LIKE '%{nameMatch}%'";
            }
            else if (IDMatch.Length > 0)
            {
                sql += $" WHERE StaffID LIKE '%{IDMatch}%'";
            }
            else if (nameMatch.Length > 0)
            {
                sql += $" WHERE Name LIKE '%{nameMatch}%'";
            }
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            return dt;
        }

        public static void DeleteStaff(string staffID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $@"DELETE FROM Account WHERE StaffID = '{staffID}'";
            RecordActivity(sql);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = $@"UPDATE Staff SET State = 'Leave' WHERE StaffID = '{staffID}'";
            RecordActivity(sql);
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static string[] GetAllLocID()
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = "SELECT LocID FROM Location";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            string[] LocIDArray = dt.AsEnumerable().Select(r => r.Field<string>("LocID")).ToArray();
            return LocIDArray;
        }

        public static bool CreateStaffRecord(string[] stringData)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            if (stringData[0] == null)
            {
                string sqlTemp = "SELECT * FROM Staff ORDER BY StaffID DESC LIMIT 1";
                RecordActivity(sqlTemp);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlTemp, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataRow response = dt.Rows[0];
                string lastStaffID = (string)response["StaffID"];
                int numID = int.Parse(lastStaffID.Substring(1)) + 1;
                stringData[0] = 'S' + numID.ToString().PadLeft(9, '0');
            }

            string sql = $@"INSERT INTO Staff VALUES ('{stringData[0]}', '{stringData[1]}', '{stringData[2]}','{stringData[3]}', '{stringData[4]}', '{stringData[5]}', '{stringData[6]}', '{stringData[7]}', {stringData[8]}, '{stringData[9]}')";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool ModifyStaffRecord(string[] stringData)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $@"INSERT INTO Staff VALUES (
                '{stringData[0]}',
                '{stringData[1]}',
                '{stringData[2]}',
                '{stringData[3]}',
                '{stringData[4]}',
                '{stringData[5]}',
                '{stringData[6]}',
                '{stringData[7]}',
                {stringData[8]},
                '{stringData[9]}')";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static DataTable GetAllAgreementRecord(string agreeID = "", string suppName = "", string AgreementType = "", string createDate = "")
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = @"SELECT DISTINCT a.AgreementID, s.Name AS SupplierName, a.BuyerID, a.AgreementType, a.CreatedDate, a.EffectiveDate, a.State, a.TermAndCondition
                FROM Agreement AS a
                LEFT JOIN BPAItem AS b ON b.BPA_ID = a.AgreementID
                LEFT JOIN CPAItem AS c ON c.CPA_ID = a.AgreementID
                LEFT JOIN PPOItem AS p ON p.PPO_ID = a.AgreementID
                JOIN Item AS i ON i.ItemID = b.ItemID OR i.ItemID = c.ItemID OR i.ItemID = p.ItemID
                JOIN SupplierItem AS si ON si.SupplierID = i.SupplierID AND si.SupplierItemID = i.SupplierItemID
                JOIN Supplier AS s ON s.SupplierID = si.SupplierID";

            string connector = "WHERE";
            if (suppName.Length > 0)
            {
                sql += $" WHERE s.Name LIKE '%{suppName}%'";
                connector = "AND";
            }
            if (agreeID.Length > 0)
            {
                sql += $" {connector} a.AgreementID LIKE '%{agreeID}%'";
                connector = "AND";
            }
            if (AgreementType.Length > 0)
            {
                sql += $" {connector} a.AgreementType = '{AgreementType}'";
                connector = "AND";
            }
            if (createDate.Length > 0)
            {
                sql += $@" {connector} a.CreatedDate >= DATE_SUB('{createDate}', INTERVAL 7 DAY)
                    AND a.CreatedDate <= DATE_ADD('{createDate}', INTERVAL 7 DAY)";
            }

            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            return dt;
        }

        public static DataTable[] GetAgreementDetail()
        {
            DataTable[] result = new DataTable[3];

            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = @"SELECT *
                FROM Agreement AS a
                INNER JOIN BPAItem AS b ON b.BPA_ID = a.AgreementID
                JOIN Item AS i ON i.ItemID = b.ItemID
                JOIN SupplierItem AS si ON si.SupplierID = i.SupplierID AND si.SupplierItemID = i.SupplierItemID
                JOIN Supplier AS s ON s.SupplierID = si.SupplierID";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            result[0] = new DataTable();
            adapter.Fill(result[0]);

            sql = @"SELECT *
                FROM Agreement AS a
                INNER JOIN CPAItem AS c ON c.CPA_ID = a.AgreementID
                JOIN Item AS i ON i.ItemID = c.ItemID
                JOIN SupplierItem AS si ON si.SupplierID = i.SupplierID AND si.SupplierItemID = i.SupplierItemID
                JOIN Supplier AS s ON s.SupplierID = si.SupplierID";
            RecordActivity(sql);
            adapter = new MySqlDataAdapter(sql, conn);
            result[1] = new DataTable();
            adapter.Fill(result[1]);

            sql = @"SELECT *
                FROM Agreement AS a
                INNER JOIN PPOItem AS p ON p.PPO_ID = a.AgreementID
                JOIN Item AS i ON i.ItemID = p.ItemID
                JOIN SupplierItem AS si ON si.SupplierID = i.SupplierID AND si.SupplierItemID = i.SupplierItemID
                JOIN Supplier AS s ON s.SupplierID = si.SupplierID";
            RecordActivity(sql);
            adapter = new MySqlDataAdapter(sql, conn);
            result[2] = new DataTable();
            adapter.Fill(result[2]);

            conn.Close();
            return result;
        }

        public static bool UpdateAgreement(string[] stringData, string oldType)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql;
            MySqlDataAdapter adapter;

            if (!stringData[2].Equals(oldType))
            {
                string typeTable;
                string idName;
                switch (oldType)
                {
                    case "B":
                        typeTable = "BPAItem";
                        idName = "BPA_ID";
                        break;
                    case "C":
                        typeTable = "CPAItem";
                        idName = "CPA_ID";
                        break;
                    case "P":
                        typeTable = "PPOItem";
                        idName = "PPO";
                        break;
                    default:
                        return false;
                }
                sql = $"SELECT * FROM {typeTable} WHERE {idName} = '{stringData[0]}'";
                RecordActivity(sql);
                adapter = new MySqlDataAdapter(sql, conn);
                DataTable subRecord = new DataTable();
                adapter.Fill(subRecord);
                if (subRecord.Rows.Count > 0) return false;
            }

            sql = $@"UPDATE Agreement SET
                BuyerID = '{stringData[1]}',
                AgreementType = '{stringData[2]}',
                CreatedDate = '{stringData[3]}',
                EffectiveDate = '{stringData[4]}',
                State = '{stringData[5]}',
                TermAndCondition = '{stringData[6]}'
                WHERE AgreementID = '{stringData[0]}'";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static DataTable GetPPOTable(string ppoID = "")
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $"SELECT * FROM PPO";
            if (ppoID.Length > 0) sql += $" WHERE PPO_ID = '{ppoID}'";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            return dt;
        }

        public static bool CreatePPO(string ppoID, string locID, string schedule, string currency)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $"INSERT INTO PPO VALUES ('{ppoID}', '{locID}', '{schedule}', '{currency}')";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static DataTable GetCPAItemTable(string cpaID = "")
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = $"SELECT * FROM CPAItem";
            if (cpaID.Length > 0) sql += $" WHERE CPA_ID = '{cpaID}'";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            return dt;
        }
        public static DataTable GetBPAItemTable(string bpaID = "")
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = "SELECT * FROM BPAItem";
            if (bpaID.Length > 0) sql += $" WHERE BPA_ID = '{bpaID}'";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            return dt;
        }
        public static DataTable GetPPOItemTable(string ppoID = "")
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = "SELECT * FROM PPOItem";
            if (ppoID.Length > 0) sql += $" WHERE PPO_ID = '{ppoID}'";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            return dt;
        }

        public static bool UpdateCPAItem(string agreeID, string itemID, string oldItemID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $"UPDATE CPAItem SET ItemID = '{itemID}' WHERE CPA_ID = '{agreeID}' AND ItemID = '{oldItemID}'";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool UpdateBPAItem(string[] stringData, string oldItemID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $@"UPDATE BPAItem SET
                ItemID = '{stringData[1]}',
                AmountAgreed = {stringData[2]},
                AmountDelivered = {stringData[3]},
                UnitPrice = {stringData[4]},
                Currency = '{stringData[5]}',
                PriceBreakAmount = {stringData[6]},
                Discount = {stringData[7]},
                PriceBreakEffectiveDate = '{stringData[8]}'
                WHERE BPA_ID = '{stringData[0]}'
                AND ItemID = '{oldItemID}'";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool UpdatePPOItem(string agreeID, string itemID, string quantity, string unitPrice, string oldItemID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $@"UPDATE PPOItem SET
                ItemID = '{itemID}',
                Quantity = {quantity},
                UnitPrice = {unitPrice}
                WHERE PPO_ID = '{agreeID}'
                AND ItemID = '{oldItemID}'";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool CreateAgreement(string[] stringData)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $@"INSERT INTO Agreement VALUES (
                '{stringData[0]}',
                '{stringData[1]}',
                '{stringData[2]}',
                '{stringData[3]}',
                '{stringData[4]}',
                '{stringData[5]}',
                '{stringData[6]}' )";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static DataTable GetAllItemDetail()
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = @"SELECT i.ItemID, si.SupplierID, si.SupplierItemID, si.Name, si.Category, si.Description
                FROM Item AS i
                JOIN SupplierItem AS si ON si.SupplierID = i.SupplierID AND si.SupplierItemID = i.SupplierItemID";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            return dt;
        }

        public static bool CreateCPAITem(string agreeID, string itemID)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $"INSERT INTO CPAItem VALUES ('{agreeID}', '{itemID}')";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool CreatePPOItem(string agreeID, string itemID, string quantity, string unitPrice)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $"INSERT INTO PPOItem VALUES ('{agreeID}', '{itemID}', {quantity}, {unitPrice})";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool CreateBPAItem(string[] stringData)
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            conn.Open();

            string sql = $@"INSERT INTO BPAItem VALUES (
                '{stringData[0]}',
                '{stringData[1]}',
                {stringData[2]},
                {stringData[3]},
                {stringData[4]},
                '{stringData[5]}',
                {stringData[6]},
                {stringData[7]},
                '{stringData[8]}')";
            RecordActivity(sql);
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                return count != 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static DataTable GetActivityLog()
        {
            MySqlConnection conn = new MySqlConnection { ConnectionString = connString };
            string sql = "SELECT * FROM ActivityLog";
            RecordActivity(sql);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return null;

            return dt;
        }
    }
}

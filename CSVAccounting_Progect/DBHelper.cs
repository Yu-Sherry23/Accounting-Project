using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSVAccounting_Progect
{
    public static class DBHelper
    {
        //建立資料表
        public static void InitDb()
        {
            //開啟資料庫
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = """
                    CREATE TABLE if not exists "item" (
                    	"id"	INTEGER,
                    	"date"	TEXT NOT NULL,
                    	"note"	TEXT,
                    	"amount"	REAL NOT NULL DEFAULT 1,
                    	"category"	TEXT NOT NULL DEFAULT '食',
                    	"isincome"	INTEGER NOT NULL DEFAULT 0,
                    	PRIMARY KEY("id" AUTOINCREMENT)
                    );
                
                    """;
                //建資料表
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Item> GetAllItems()
        {
            var result = new List<Item>();

            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = "select * from item";


                //建資料表
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new Item();
                            item.Id = Convert.ToInt32(reader["id"]);
                            item.Date = Convert.ToDateTime(reader["date"]);
                            item.Amount = Convert.ToDecimal(reader["amount"]);
                            item.Note = reader["note"].ToString()!;
                            item.CategoryType = (Category)Enum.Parse(typeof(Category), reader["category"].ToString()!);
                            item.IsIncome = Convert.ToInt32(reader["isincome"]) == 1;
                            result.Add(item);
                        }
                    }
                }
            }

            return result;
        }




        //新增資料
        public static void InsertItem(Item item)
        {
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = """
                    
                    insert into item(date,note,amount,category,isincome) values
                    (@date,@note,@amount,@category,@isincome);
                    """;

                //建資料表
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", item.Date.ToString("yyyy-MM-dd hh:mm:ss"));
                    cmd.Parameters.AddWithValue("@note", item.Note);
                    cmd.Parameters.AddWithValue("@amount", (double)item.Amount);
                    cmd.Parameters.AddWithValue("@category", item.CategoryType.ToString());
                    cmd.Parameters.AddWithValue("@isincome", item.IsIncome);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        //刪除
        public static void DeleteItem(Item item)
        {
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = "delete from item where id=@id";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool UpdateItem(Item item)
        {
            using (var connection = new SqliteConnection("Data Source=accounting.db"))
            {
                connection.Open();
                string sql = @"
                    update item set                             
                    date=@date,
                    note=@note,
                    amount=@amount,
                    isincome=@isincome,
                    category=@category
                    where id=@id";


                using (var cmd = new SqliteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue(
                        "@date", item.Date.ToString("yyyy-MM-dd HH:mm:ss")
                        );
                    cmd.Parameters.AddWithValue(
                    "@note", item.Note);
                    cmd.Parameters.AddWithValue(
                    "@amount", item.Amount);
                    cmd.Parameters.AddWithValue(
                    "@isincome", item.IsIncome ? 1 : 0);
                    cmd.Parameters.AddWithValue(
                    "@category", item.CategoryType.ToString());
                    cmd.Parameters.AddWithValue(
                        "@id", item.Id);

                    cmd.ExecuteNonQuery();
                }
            }


            return true;

        }



        public static void DeleteAllItem()
        {
            using (var conn = new SqliteConnection("Data Source=accounting.db"))
            {
                conn.Open();
                string sql = "delete from item item";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                   
                    cmd.ExecuteNonQuery();
                }
            }
        }






    }




}

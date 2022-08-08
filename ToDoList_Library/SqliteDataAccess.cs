using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_Library
{
    public class SqliteDataAccess
    {
       
        public static List<TopicModel> LoadTopics(int searchId, string requestFormat = "None")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT id_topic, description, demand, id_category, id_level FROM Topics";
                if (requestFormat == "None")
                {
                    query += "ORDER BY demand DESC";
                    var output = cnn.Query<TopicModel>(query, new DynamicParameters());
                    return output.ToList();
                }
                if (requestFormat == "Category")
                {
                    query += $"WHERE id_category = {searchId}";
                    var output = cnn.Query<TopicModel>(query, new DynamicParameters());
                    return output.ToList();
                }
                if (requestFormat == "Priority Level")
                {
                    query += $"WHERE id_level = {searchId}";
                    var output = cnn.Query<TopicModel>(query, new DynamicParameters());
                    return output.ToList();
                }
                return null; //It should never reach here
            }
        }
        
        public static List<TopicModel> LoadTopics()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TopicModel>("SELECT id_topic, description, demand, id_category, id_level FROM" +
                    " Topics ORDER BY demand DESC", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTopic(TopicModel topic)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Topics (description, id_category, id_level) VALUES (@Description, @Category, @PriorityLevel)", topic);
            }
        }

        public static List<CategoryModel> LoadCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("SELECT * FROM Categories", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveCategory(CategoryModel category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Categories (name) VALUES (@Name)", category);
            }
        }

        public static List<PriorityLevelModel> LoadPriorityLevels()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PriorityLevelModel>("SELECT * FROM Levels", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePriorityLevel(PriorityLevelModel level)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Levels (name, weight) VALUES (@Name, @Weight)", level);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

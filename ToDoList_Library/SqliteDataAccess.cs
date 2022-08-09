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
       
        public static List<TopicModel> LoadTopics(int searchId, string filter = "None")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT id_topic, description, demand, id_category, id_level FROM Topics";
                // This three lines could be done after the last if so it defaults to this filter and never returns null
                // but I'm scared to break this :(
                if (filter == "None") 
                {
                    query += "ORDER BY demand DESC";
                    var output = cnn.Query<TopicModel>(query, new DynamicParameters()); 
                    return output.ToList();
                }
                if (filter == "Category")
                {
                    query += $"WHERE id_category = {searchId} ORDER BY demand DESC";
                    var output = cnn.Query<TopicModel>(query, new DynamicParameters());
                    return output.ToList();
                }
                if (filter == "Priority Level")
                {
                    query += $"WHERE id_level = {searchId} ORDER BY demand DESC";
                    var output = cnn.Query<TopicModel>(query, new DynamicParameters());
                    return output.ToList();
                }
                return null; //It never reaches here, unless a not implemented type of filter is passed
            }
        }
        
        public static List<TopicModel> LoadHighestPriorityTopics(int searchId = 0, string filter = "None")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT id_topic, description, demand, id_category, Topics.id_level FROM Topics " +
                    "INNER JOIN Levels ON Topics.id_level = Levels.id_level ";
                if (filter == "None")
                {
                    query += "ORDER BY weight DESC LIMIT 10";
                    var output = cnn.Query<TopicModel>(query, new DynamicParameters());
                    return output.ToList();
                }
                if (filter == "Category")
                {
                    query += $"WHERE id_category = {searchId}  ORDER BY weight DESC LIMIT 10";
                    var output = cnn.Query<TopicModel>(query, new DynamicParameters());
                    return output.ToList();
                }
                if (filter == "Priority Level")
                {
                    query += $"WHERE id_level = {searchId}  ORDER BY weight DESC LIMIT 10";
                    var output = cnn.Query<TopicModel>(query, new DynamicParameters());
                    return output.ToList();
                }
                return null; 
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

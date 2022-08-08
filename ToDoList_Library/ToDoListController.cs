
using System;
using System.Collections.Generic;

namespace ToDoList_Library
{
    public class ToDoListController
    {
        private List<TopicModel> topics = new List<TopicModel>();
        private List<CategoryModel> categories = new List<CategoryModel>();
        private List<PriorityLevelModel> priorityLevels = new List<PriorityLevelModel>();

        public ToDoListController()
        {
            LoadTopics();
            LoadCategories();
            LoadLevels();
        }

        public void RefreshLists()
        {
            LoadTopics();
            LoadCategories();
            LoadLevels();
        }

        public List<TopicModel> RequestTopics(string sort = "None")
        {
            if (sort == "None")
            {
                return topics;
            }
            return null; //It never reaches here
        }

        public List<CategoryModel> RequestCategories()
        {
            return categories;
        }

        public List<PriorityLevelModel> RequestPriorityLevels()
        {
            return priorityLevels;
        }

        public string AddTopic(string description, int id_category, int id_level)
        {
            if (string.IsNullOrEmpty(description))
                return "The Description field is required";
            if (id_category < 0)
                return "You must choose a Category";
            if (id_level < 0)
                return "You must choose a Priority Level";
            TopicModel topic = new TopicModel(description, id_category, id_level);
            try
            {
                SqliteDataAccess.SaveTopic(topic);
                return "The new Topic has been added successfully";
            }
            catch (Exception e)
            {
                return "An Error has occurred \n" + e.Message;
            }
        }

        private void LoadTopics()
        {
            topics = SqliteDataAccess.LoadTopics();
        }

        public string AddCategory(string name)
        {
            if (string.IsNullOrEmpty(name))
                return "The Description field is required";
            CategoryModel category = new CategoryModel(name);
            try
            {
                SqliteDataAccess.SaveCategory(category);
                return "The new Category has been added successfully";
            }
            catch (Exception e)
            {
                return "An Error has occurred \n" + e.Message;
            }
        }

        private void LoadCategories()
        {
            categories = SqliteDataAccess.LoadCategories();
        }

        public string AddLevel(string name, int weight)
        {
            if (string.IsNullOrEmpty(name))
                return "The Description field is required";
            if (weight < 0)
                return "The Weight value is invalid";
            PriorityLevelModel level = new PriorityLevelModel(name, weight);
            try
            {
                SqliteDataAccess.SavePriorityLevel(level);
                return "The new Priority Level has been added";
            }
            catch (Exception e)
            {
                return "An Error has occurred \n" + e.Message;
            }
        }
        private void LoadLevels()
        {
            priorityLevels = SqliteDataAccess.LoadPriorityLevels();
        }

    }
}

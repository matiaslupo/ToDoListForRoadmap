namespace ToDoList_Library
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CategoryModel()
        {

        }
        public CategoryModel(string name)
        {
            Name = name;
        }
    }
}

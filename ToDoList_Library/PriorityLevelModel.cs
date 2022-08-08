namespace ToDoList_Library
{
    public class PriorityLevelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public int Weight { get; set; }

        public PriorityLevelModel()
        { }

        public PriorityLevelModel(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }   
    }
}

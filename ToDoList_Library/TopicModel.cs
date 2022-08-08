namespace ToDoList_Library
{
    public class TopicModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Demand { get; set; }
        public int Category { get; set; }
        public int PriorityLevel { get; set; }
        public string DemandDisplay
        {
            get { return $"{Description}. . .  {Demand}"; }
        }

        public TopicModel( string description, int category, int priorityLevel)
        {
            Description = description;
            Category = category;
            PriorityLevel = priorityLevel;
            Demand = 0;
        }
        public TopicModel(int id, string description, int demand, int category, int priorityLevel)
        {
            Id = id;
            Description = description;
            Demand = demand;
            Category = category;
            PriorityLevel = priorityLevel;
        }

        public TopicModel()
        {

        }
    }
}

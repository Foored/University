namespace University.Entities
{
    public class Course : Entity
    {
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public string Name { get; set; }
    }
}

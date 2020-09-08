namespace University.Entities
{
    public class Student : Entity
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

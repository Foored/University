using System;

namespace University.Entities
{
    public class Grade : Entity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }
}

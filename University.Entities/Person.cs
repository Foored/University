using System;
using System.Collections.Generic;
using System.Text;

namespace University.Entities
{
    public class Person : Entity
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

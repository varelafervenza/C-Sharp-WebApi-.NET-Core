using System.Collections.Generic;

namespace QDOT.Model
{
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Skill> Skills { get; set; }
    }
}

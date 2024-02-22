using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities;

public class Instructor : Entity
{
    public virtual ICollection<Course> Courses { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Instructor()
    {
        
    }
    public Instructor(int id, string firstName, string lastName) : this()
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
}

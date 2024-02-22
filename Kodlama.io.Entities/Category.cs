using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities;

public class Category : Entity
{
    public virtual ICollection<Course> Courses { get; set; }
    public string CategoryName { get; set; }
    public Category()
    {
        
    }
    public Category(int id, string categoryName) : this()
    {
        Id = id;
        CategoryName = categoryName;
    }
}

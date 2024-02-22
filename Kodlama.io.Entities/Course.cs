using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities;

public class Course : Entity
{
    public virtual Category? Category { get; set; }
    public int CategoryId { get; set; }
    public virtual Instructor? Instructor { get; set; }
    public int InstructorId { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    public double Price { get; set; }
    public Course()
    {

    }
    public Course(int id, int categoryId, int instructorId, string courseName, string courseDescription, double price) : this()
    {
        Id = id;
        CategoryId = categoryId;
        InstructorId = instructorId;
        CourseName = courseName;
        CourseDescription = courseDescription;
        Price = price;
    }
}

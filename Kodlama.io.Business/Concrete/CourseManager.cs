using Kodlama.io.Business.Abstract;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Concrete;

public class CourseManager : ICourseService
{
    public void Add(Course course)
    {
        Console.WriteLine("Kurs eklendi: " + course.CourseName);
    }

    public void Delete(Course course)
    {
        Console.WriteLine("Kurs silindi: " + course.CourseName);
    }

    public List<Course> GetAll()
    {
        List<Course> courses = new List<Course>();
        return courses;
    }

    public void Update(Course course)
    {
        Console.WriteLine("Kurs güncellendi: " + course.CourseName);
    }
}

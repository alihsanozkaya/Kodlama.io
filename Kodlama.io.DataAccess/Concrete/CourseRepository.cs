using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concrete;

public class CourseRepository : ICourseRepository
{
    public void Add(Course course)
    {
        Console.WriteLine("Veritabanına kurs eklendi");
    }

    public void Delete(Course course)
    {
        Console.WriteLine("Veritabanından kurs silindi");
    }

    public List<Course> GetAll()
    {
        List<Course> courses = new List<Course>();
        return courses;
    }

    public void Update(Course course)
    {
        Console.WriteLine("Veritabanındaki kurs güncellendi");
    }
}

using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concrete;

public class InstructorRepository
{
    public void Add(Instructor instructor)
    {
        Console.WriteLine("Veritabanına eğitmen eklendi");
    }

    public void Delete(Instructor instructor)
    {
        Console.WriteLine("Veritabanından eğitmen silindi");
    }

    public List<Instructor> GetAll()
    {
        List<Instructor> instructors = new List<Instructor>();
        return instructors;
    }

    public void Update(Instructor instructor)
    {
        Console.WriteLine("Veritabanındaki eğitmen güncellendi");
    }
}

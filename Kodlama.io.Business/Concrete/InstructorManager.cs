using Kodlama.io.Business.Abstract;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Concrete;

public class InstructorManager : IInstructorService
{
    public void Add(Instructor instructor)
    {
        Console.WriteLine("Eğitmen eklendi: " + instructor.FirstName + " " + instructor.LastName);
    }

    public void Delete(Instructor instructor)
    {
        Console.WriteLine("Eğitmen silindi: " + instructor.FirstName + " " + instructor.LastName);
    }

    public List<Instructor> GetAll()
    {
        List<Instructor> instructors = new List<Instructor>();
        return instructors;
    }

    public void Update(Instructor instructor)
    {
        Console.WriteLine("Eğitmen güncellendi: " + instructor.FirstName + " " + instructor.LastName);
    }
}

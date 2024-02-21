using Kodlama.io.Business.Abstract;
using Kodlama.io.Business.Concrete;
using Kodlama.io.Entities;

namespace Kodlama.io.Console;

class Program
{
    static void Main(string[] args)
    {
        Instructor instructor = new Instructor
        {
            Id = 1,
            FirstName = "Engin",
            LastName = "Demiroğ"
        };
        IService<Instructor> service = new InstructorManager();
        service.Add(instructor);

    }
}
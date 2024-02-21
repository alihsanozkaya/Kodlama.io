using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concrete;

public class CategoryRepository : ICategoryRepository
{
    public void Add(Category category)
    {
        Console.WriteLine("Veritabanına kategori eklendi");
    }

    public void Delete(Category category)
    {
        Console.WriteLine("Veritabanından kategori silindi");
    }

    public List<Category> GetAll()
    {
        List<Category> categories = new List<Category>();
        return categories;
    }

    public void Update(Category category)
    {
        Console.WriteLine("Veritabanındaki kategori güncellendi");
    }
}

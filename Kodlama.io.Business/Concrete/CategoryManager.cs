using Kodlama.io.Business.Abstract;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Concrete;

public class CategoryManager : ICategoryService
{
    public void Add(Category category)
    {
        Console.WriteLine("Kategori eklendi: " + category.CategoryName);
    }

    public void Delete(Category category)
    {
        Console.WriteLine("Kategori silindi: " + category.CategoryName);
    }

    public List<Category> GetAll()
    {
        List<Category> categories = new List<Category>();
        return categories;
    }

    public void Update(Category category)
    {
        Console.WriteLine("Kategori güncellendi: " + category.CategoryName);
    }
}

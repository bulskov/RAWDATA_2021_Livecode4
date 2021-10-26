using EfEx.Domain;
using System;
using System.Linq;

namespace EfEx
{
    internal class EfProgram
    {
        static void Main(string[] args)
        {
            var ctx = new NorthwindContext();

            var categories = ctx.Categories;

            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }

            //var cat = new Category
            //{
            //    Id = 101,
            //    Name = "fdfjslfdjfk",
            //    Description = "blah blah"
            //};

            //ctx.Categories.Add(cat);
            //ctx.SaveChanges();

            var cat = ctx.Categories.Find(101);

            cat.Name = "New name";
            ctx.SaveChanges();





            //ctx.Categories.Remove(ctx.Categories.Find(101));
            //ctx.SaveChanges();
        }
    }
}

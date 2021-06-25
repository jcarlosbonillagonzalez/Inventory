using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAcces;
using System.Linq;

namespace Business
{
    public class B_Category
    {

        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        public static CategoryEntity CategoryById(int Id)
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList().LastOrDefault(p => p.CategoryId == Id);
            }
        }

        public static void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }
    }
}

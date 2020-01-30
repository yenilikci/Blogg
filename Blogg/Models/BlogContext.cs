using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blogg.Models
{
    //bizim için veritabanını yöneten bir sınıf 
    public class BlogContext:DbContext
    {
        public BlogContext():base("bloggDb") //farklı isimle veritabani oluşturmak
        {
            Database.SetInitializer(new BlogInitializer());
        }
        //birinci entity blog bu tablo gibi düşünülmeli , tipi DbSet
        public DbSet<Blog> Bloglar { get; set; }
        //ikinci entity kategori bu da tablo gibi düşünülmeli , tipi DbSet (listelere benzer , sınıfları temsil eder,generic bir tip)
        public DbSet<Category> Kategoriler { get; set; }
    }
}
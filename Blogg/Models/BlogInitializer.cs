using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blogg.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() {KategoriAdi= "C#"},
                new Category() {KategoriAdi = "Asp.net MVC"},
                new Category() {KategoriAdi = "Asp.net WebForm"},
                new Category() {KategoriAdi = "Windows Form"}
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item); //Kategorileri ekledim
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=1},
                new Blog() {Baslik="C# Delegates",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-12),Anasayfa=true,Onay=false,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=1},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-17),Anasayfa=false,Onay=true,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=1},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-19),Anasayfa=true,Onay=true,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=2},
                new Blog() {Baslik="C# Generic List Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-24),Anasayfa=true,Onay=true,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=2},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-27),Anasayfa=false,Onay=false,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=2},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-29),Anasayfa=true,Onay=true,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=3},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-13),Anasayfa=true,Onay=true,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=3},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-7),Anasayfa=false,Onay=false,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=3},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-9),Anasayfa=true,Onay=true,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=4},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-14),Anasayfa=false,Onay=true,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=4},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında Öğretici Makale",EklenmeTarihi=DateTime.Now.AddDays(-16),Anasayfa=true,Onay=false,İcerik="C# Delegates Hakkında Öğretici Makale Anlatımı",Resim="delegates.jpg",CategoryId=4}
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges(); 

            base.Seed(context);
        }
    }
}
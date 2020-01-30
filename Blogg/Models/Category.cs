using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogg.Models
{
    public class Category
    {
        //veritabanında olacak
        public int Id { get; set; } //int id birincil anahtar Category için
        public string KategoriAdi { get; set; } 
        //her bir kateogriye ait olan birden fazla blog olacağı için bloglar liste tipinde.
        public List<Blog> Bloglar { get; set; }

    }
}
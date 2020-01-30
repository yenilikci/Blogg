using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogg.Models
{
    public class Blog
    {
        public int Id { get; set; } //int id birincil anahtar Blog için
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string İcerik { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }

        public int CategoryId { get; set; } //navigation property, yabancı anahtar her blog bir kategoriye ait gibi
        public Category Category { get; set; } //herhangi bir blogun ilgili kategori bilgilerine ulaşmak için
    }                                               
}
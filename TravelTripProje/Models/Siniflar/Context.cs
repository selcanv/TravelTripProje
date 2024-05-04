using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet <Admin> Admins { get; set; }  //dbcontext ten miras aldığım için databaseset (dbset) geliyor <Admin> sınıfı kullanmak istiyorum veriranabında da bu admins (peluayz) olacak 
        public DbSet <AdresBlog> AdresBlogs { get; set; }
        public DbSet <Blog> Blogs { get; set; }
        public DbSet <Hakkimizda> Hakkimizdas { get; set; }
        public DbSet <Iletisim> Iletisims { get; set; }
        public DbSet <Yorumlar> Yorumlars { get; set; }
       
    }
}
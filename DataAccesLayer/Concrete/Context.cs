using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context :IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-ISO96UVH\\SQLEXPRESS;database=TravelsalDB;integrated security=true;");


        }
        public DbSet<About> Abouts { get; set; }//Entity'leri sql'e bu property'ler ile yansıtıyoruz. s takısı almış hali tablo ismi About yalın hali entity ismi olur
        public DbSet<About2> About2s { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<SubFeature> SubFeatures{ get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<DestinationDetails> DestinationDetailss { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}

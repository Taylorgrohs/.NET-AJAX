using AjaxDemo.Models;
using Microsoft.Data.Entity;

namespace AjaxDemo.Models
{
    public class AjaxDemoContext : DbContext
    {
        public virtual DbSet<Destination> Destinations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AjaxDemo;integrated security = True");
        }
    }
}
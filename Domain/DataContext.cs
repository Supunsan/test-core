using Microsoft.EntityFrameworkCore;
using YukonTest.Models;

namespace YukonTest.Domain
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers{ get; set; }
    }
}
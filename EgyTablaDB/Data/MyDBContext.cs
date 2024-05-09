using EgyTablaDB.Model;
using Microsoft.EntityFrameworkCore;

namespace EgyTablaDB.Data
{
    public class MyDBContext:DbContext

    {
        public MyDBContext(DbContextOptions<MyDBContext>options):base(options) { }

        public DbSet<Student> Students { get; set; } = default;
    }
}

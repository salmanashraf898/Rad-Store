using Microsoft.EntityFrameworkCore;
using Rad_Store.Model;
namespace Rad_Store.Data
{
    public class database : DbContext
    {
        public database(DbContextOptions<database> dbdatabase) : base (dbdatabase)
            {

}
        public DbSet<Contact> contacts { get; set; }
    }
}

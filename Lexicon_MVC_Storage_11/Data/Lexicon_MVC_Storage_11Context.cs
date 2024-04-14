using Microsoft.EntityFrameworkCore;
using Lexicon_MVC_Storage_11.Models;

namespace Lexicon_MVC_Storage_11.Data
{
    public class Lexicon_MVC_Storage_11Context : DbContext
    {
        public Lexicon_MVC_Storage_11Context (DbContextOptions<Lexicon_MVC_Storage_11Context> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerCodegen.ExampleAPI.Db
{
    public class ItemsDbContext : DbContext
    {
        public ItemsDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}

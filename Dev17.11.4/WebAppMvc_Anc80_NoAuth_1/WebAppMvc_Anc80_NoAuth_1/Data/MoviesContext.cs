using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMvc_Anc80_NoAuth_1.Models;

namespace WebAppMvc_Anc80_NoAuth_1.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMvc_Anc80_NoAuth_1.Models.Movie> Movie { get; set; } = default!;
    }
}

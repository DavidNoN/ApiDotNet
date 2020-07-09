using Microsoft.EntityFrameworkCore;
using ASP.NET.Models;


namespace ParkyApi.Data
{
    
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base( options )
        {

        }

        public DbSet<NationalPark> NationalPark { get; set; }
    }

    
}
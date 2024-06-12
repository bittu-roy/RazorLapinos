using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RazorLapinos.Models;

namespace RazorLapinos.Data
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options)
             : base(options)
        {
            
        }
    }
}

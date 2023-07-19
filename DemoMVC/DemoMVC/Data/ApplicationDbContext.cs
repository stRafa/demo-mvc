using DemoMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DemoMVC.Models.Aluno> Aluno { get; set; } = default!;
        public DbSet<DemoMVC.Models.Filme> Filme { get; set; } = default!;
    }
}
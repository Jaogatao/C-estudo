using Antônio.Desktop.CrudTeste;
using Antônio.Desktop.CrudTeste.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace jaoteste.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students {get; set; } = default!;
    public DbSet<Premium> Premiums {get; set; } = default!;
}

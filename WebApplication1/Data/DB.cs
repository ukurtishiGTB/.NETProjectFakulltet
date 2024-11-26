using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class DB: DbContext
{

    public DB(DbContextOptions<DB> options) : base(options) { }
    DbSet<Student> Students { get; set; }
}
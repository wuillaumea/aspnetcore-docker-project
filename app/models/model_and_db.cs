using System;
using Microsoft.EntityFrameworkCore;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

}

public class WebAPIDataContext : DbContext
{
    public WebAPIDataContext(DbContextOptions<WebAPIDataContext> options)
        : base(options)
    {
    }
    public DbSet<Book> Books { get; set; }
}
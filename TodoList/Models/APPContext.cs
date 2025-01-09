using Microsoft.EntityFrameworkCore;

namespace TodoList.Models
{
	public class APPContext : DbContext
	{
		public DbSet<User> User { get; set; }
		public DbSet<Note> Note  { get; set; }

		public APPContext() : base() { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//Write your DataSource and Catalog 
			optionsBuilder.UseSqlServer
				("Data Source=????\\SQLEXPRESS;Initial Catalog=????;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
			base.OnConfiguring(optionsBuilder);
		}
	}
}

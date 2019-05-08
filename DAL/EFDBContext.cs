using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
	public class EFDBContext : DbContext
	{
		public DbSet<Directory> Directory { get; set; } 
		public DbSet<Material> Material { get; set; }

		public EFDBContext (DbContextOptions<EFDBContext> options):base(options){	} //Конструктор

		/// <summary>
		/// For Migrations
		/// </summary>
		public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
		{
			public EFDBContext CreateDbContext(string[] args)
			{
				var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
				optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebAppTierThreeDb;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DAL"));

				return new EFDBContext(optionsBuilder.Options);
			}
		}
	}
}

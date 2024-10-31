using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace Barroc_Intensive.Data
{
	internal class AppDbContext : DbContext
	{

		public DbSet<User> Users { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql(
				ConfigurationManager.ConnectionStrings["AppDbContext"].ConnectionString,
				ServerVersion.Parse("5.7.33")
			);
		}

	}
}

using Data.Map;
using Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class Persistencia : DbContext
	{
		public Persistencia() : base("ProjetoBNPContext")
		{

		}

		public DbSet<ProdutoCosif> ProdutoCosif { get; set; }
		public DbSet<Produto> Produto { get; set; }
		public DbSet<MovimentoManual> MovimentoManual { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			var typesToMapping = (from x in Assembly.GetExecutingAssembly().GetTypes()
								  where x.IsClass && typeof(IMapeamento).IsAssignableFrom(x)
								  select x).ToList();
			// Varrendo todos os tipos que são mapeamento 
			// Com ajuda do Reflection criamos as instancias 
			// e adicionamos no Entity Framework
			foreach (var mapping in typesToMapping)
			{
				dynamic mappingClass = Activator.CreateInstance(mapping);
				modelBuilder.Configurations.Add(mappingClass);
			}
			base.OnModelCreating(modelBuilder);
		}
	}
}

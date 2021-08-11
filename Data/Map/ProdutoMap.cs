using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Map
{
	public class ProdutoMap : EntityTypeConfiguration<Produto>, IMapeamento
	{
		public ProdutoMap()
		{
			ToTable("PRODUTO");
			Property(x => x.CodProduto).HasColumnName("COD_PRODUTO").HasColumnType("char").HasMaxLength(4);
			HasKey(x => x.CodProduto);
			Property(x => x.Descricao).HasColumnName("DES_PRODUTO").HasMaxLength(30);
			Property(x => x.Status).HasColumnName("STA_STATUS").HasColumnType("char").HasMaxLength(1);
		}
	}
}


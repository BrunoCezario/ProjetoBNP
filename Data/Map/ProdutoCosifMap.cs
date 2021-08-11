using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Map
{
	public class ProdutoCosifMap : EntityTypeConfiguration<ProdutoCosif>, IMapeamento
	{
		public ProdutoCosifMap()
		{
			ToTable("PRODUTO_COSIF");
			Property(x => x.CodCosif).HasColumnName("COD_COSIF").HasColumnType("char").HasMaxLength(11);
			HasKey(x => x.CodCosif);
			Property(x => x.CodProduto).HasColumnName("COD_PRODUTO").HasColumnType("char").HasMaxLength(4);
			Property(x => x.CodClassificacao).HasColumnName("COD_CLASSIFICACAO").HasColumnType("char").HasMaxLength(6);
			Property(x => x.Status).HasColumnName("STA_STATUS").HasColumnType("char").HasMaxLength(1);
		}
	}
}

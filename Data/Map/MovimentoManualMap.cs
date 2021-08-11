using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Map
{
	public class MovimentoManualMap : EntityTypeConfiguration<MovimentoManual>, IMapeamento
	{
		public MovimentoManualMap()
		{
			ToTable("MOVIMENTO_MANUAL");
			HasKey(x => new { x.CodProduto, x.CodCosif });
			Property(x => x.Mes).HasColumnName("DAT_MES").HasMaxLength(2).IsRequired();
			Property(x => x.Ano).HasColumnName("DAT_ANO").HasMaxLength(4).IsRequired();
			Property(x => x.NumLancamento).HasColumnName("NUM_LANCAMENTO").HasMaxLength(18).IsRequired();
			Property(x => x.Valor).HasColumnName("VAL_VALOR").HasColumnType("decimal").HasPrecision(18,2).IsRequired();
			Property(x => x.Descricao).HasColumnName("DES_DESCRICAO").HasMaxLength(50).IsRequired();
			Property(x => x.CodUsuario).HasColumnName("COD_USUARIO").HasMaxLength(15).IsRequired();
			Property(x => x.DataMovimento).HasColumnName("DAT_MOVIMENTO").HasColumnType("smalldatetime").IsRequired();

		}
	}
}

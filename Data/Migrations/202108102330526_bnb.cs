namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bnb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MOVIMENTO_MANUAL",
                c => new
                    {
                        CodProduto = c.String(nullable: false, maxLength: 128),
                        CodCosif = c.String(nullable: false, maxLength: 128),
                        DAT_MES = c.String(nullable: false, maxLength: 2),
                        DAT_ANO = c.String(nullable: false, maxLength: 4),
                        NUM_LANCAMENTO = c.String(nullable: false, maxLength: 18),
                        DES_DESCRICAO = c.String(nullable: false, maxLength: 50),
                        DAT_MOVIMENTO = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        COD_USUARIO = c.String(nullable: false, maxLength: 15),
                        VAL_VALOR = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.CodProduto, t.CodCosif });
            
            CreateTable(
                "dbo.PRODUTO",
                c => new
                    {
                        COD_PRODUTO = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        DES_PRODUTO = c.String(maxLength: 30),
                        STA_STATUS = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.COD_PRODUTO);
            
            CreateTable(
                "dbo.PRODUTO_COSIF",
                c => new
                    {
                        COD_COSIF = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        COD_CLASSIFICACAO = c.String(maxLength: 6, fixedLength: true, unicode: false),
                        STA_STATUS = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        COD_PRODUTO = c.String(maxLength: 4, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.COD_COSIF);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PRODUTO_COSIF");
            DropTable("dbo.PRODUTO");
            DropTable("dbo.MOVIMENTO_MANUAL");
        }
    }
}

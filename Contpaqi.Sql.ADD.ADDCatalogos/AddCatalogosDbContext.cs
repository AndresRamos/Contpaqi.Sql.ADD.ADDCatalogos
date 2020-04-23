using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Contpaqi.Sql.ADD.ADDCatalogos
{
    public class AddCatalogosDbContext : DbContext
    {
        protected AddCatalogosDbContext()
        {
        }

        protected AddCatalogosDbContext(DbCompiledModel model) : base(model)
        {
        }

        public AddCatalogosDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public AddCatalogosDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public AddCatalogosDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public AddCatalogosDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public AddCatalogosDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public virtual DbSet<c_Aduanas> c_Aduanas { get; set; }
        public virtual DbSet<c_Banco> c_Banco { get; set; }
        public virtual DbSet<c_CatCodMoneda> c_CatCodMoneda { get; set; }
        public virtual DbSet<c_CFDIBancoR> c_CFDIBancoR { get; set; }
        public virtual DbSet<c_ClaveProdServ> c_ClaveProdServ { get; set; }
        public virtual DbSet<c_ClaveUnidad> c_ClaveUnidad { get; set; }
        public virtual DbSet<c_CodAgrup> c_CodAgrup { get; set; }
        public virtual DbSet<c_CodigoPostal> c_CodigoPostal { get; set; }
        public virtual DbSet<c_ConceptoPago> c_ConceptoPago { get; set; }
        public virtual DbSet<c_CveTipDivOUtil> c_CveTipDivOUtil { get; set; }
        public virtual DbSet<c_Estado> c_Estado { get; set; }
        public virtual DbSet<c_FormaPago> c_FormaPago { get; set; }
        public virtual DbSet<c_Impuesto> c_Impuesto { get; set; }
        public virtual DbSet<c_MetodoPago> c_MetodoPago { get; set; }
        public virtual DbSet<c_MetPag> c_MetPag { get; set; }
        public virtual DbSet<c_Moneda> c_Moneda { get; set; }
        public virtual DbSet<c_OrigenRecurso> c_OrigenRecurso { get; set; }
        public virtual DbSet<c_Pais> c_Pais { get; set; }
        public virtual DbSet<c_PeriodicidadPago> c_PeriodicidadPago { get; set; }
        public virtual DbSet<c_PeriodicidadRetenciones> c_PeriodicidadRetenciones { get; set; }
        public virtual DbSet<c_Regimen> c_Regimen { get; set; }
        public virtual DbSet<c_RegimenFiscal> c_RegimenFiscal { get; set; }
        public virtual DbSet<c_Retenciones> c_Retenciones { get; set; }
        public virtual DbSet<c_RetencionesImpuestos> c_RetencionesImpuestos { get; set; }
        public virtual DbSet<c_RiesgoPuesto> c_RiesgoPuesto { get; set; }
        public virtual DbSet<c_TipoAportODep> c_TipoAportODep { get; set; }
        public virtual DbSet<c_TipoCadena> c_TipoCadena { get; set; }
        public virtual DbSet<c_TipoContrato> c_TipoContrato { get; set; }
        public virtual DbSet<c_TipoDeComprobante> c_TipoDeComprobante { get; set; }
        public virtual DbSet<c_TipoDeduccion> c_TipoDeduccion { get; set; }
        public virtual DbSet<c_TipoHoras> c_TipoHoras { get; set; }
        public virtual DbSet<c_TipoIncapacidad> c_TipoIncapacidad { get; set; }
        public virtual DbSet<c_TipoJornada> c_TipoJornada { get; set; }
        public virtual DbSet<c_TipoNomina> c_TipoNomina { get; set; }
        public virtual DbSet<c_TipoOtroPago> c_TipoOtroPago { get; set; }
        public virtual DbSet<c_TipoPercepcion> c_TipoPercepcion { get; set; }
        public virtual DbSet<c_TipoRelacion> c_TipoRelacion { get; set; }
        public virtual DbSet<c_TipoRiesgo> c_TipoRiesgo { get; set; }
        public virtual DbSet<c_UnidadAduana> c_UnidadAduana { get; set; }
        public virtual DbSet<c_UsoCfdi> c_UsoCfdi { get; set; }
        public virtual DbSet<Control> Control { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<c_Aduanas>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_Aduanas>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_Aduanas>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_Banco>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_Banco>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_Banco>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_CatCodMoneda>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_CatCodMoneda>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_CatCodMoneda>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_CFDIBancoR>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_CFDIBancoR>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_CFDIBancoR>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_ClaveProdServ>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_ClaveProdServ>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_ClaveProdServ>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_ClaveUnidad>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_ClaveUnidad>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_ClaveUnidad>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_CodAgrup>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_CodAgrup>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_CodAgrup>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_CodigoPostal>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_CodigoPostal>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_ConceptoPago>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_ConceptoPago>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_ConceptoPago>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_CveTipDivOUtil>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_CveTipDivOUtil>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_CveTipDivOUtil>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_Estado>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_Estado>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_Estado>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_FormaPago>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_FormaPago>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_FormaPago>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_Impuesto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_Impuesto>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_Impuesto>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_MetodoPago>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_MetodoPago>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_MetodoPago>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_MetPag>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_MetPag>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_MetPag>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_Moneda>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_Moneda>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_Moneda>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_OrigenRecurso>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_OrigenRecurso>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_OrigenRecurso>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_Pais>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_Pais>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_Pais>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_PeriodicidadPago>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_PeriodicidadPago>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_PeriodicidadPago>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_PeriodicidadRetenciones>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_PeriodicidadRetenciones>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_PeriodicidadRetenciones>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_Regimen>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_Regimen>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_Regimen>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_RegimenFiscal>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_RegimenFiscal>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_RegimenFiscal>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_Retenciones>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_Retenciones>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_Retenciones>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_RetencionesImpuestos>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_RetencionesImpuestos>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_RetencionesImpuestos>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_RiesgoPuesto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_RiesgoPuesto>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_RiesgoPuesto>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoAportODep>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoAportODep>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoAportODep>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoCadena>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoCadena>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoCadena>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoContrato>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoContrato>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoContrato>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoDeComprobante>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoDeComprobante>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoDeComprobante>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoDeduccion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoDeduccion>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoDeduccion>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoHoras>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoHoras>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoHoras>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoIncapacidad>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoIncapacidad>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoIncapacidad>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoJornada>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoJornada>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoJornada>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoNomina>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoNomina>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoNomina>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoOtroPago>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoOtroPago>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoOtroPago>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoPercepcion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoPercepcion>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoPercepcion>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoRelacion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoRelacion>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoRelacion>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoRiesgo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoRiesgo>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_TipoRiesgo>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_UnidadAduana>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_UnidadAduana>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_UnidadAduana>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<c_UsoCfdi>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<c_UsoCfdi>()
                .Property(e => e.CodigoReporting)
                .IsUnicode(false);

            modelBuilder.Entity<c_UsoCfdi>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.Catalogo)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.Storage)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.TagReporting)
                .IsUnicode(false);
        }
    }
}
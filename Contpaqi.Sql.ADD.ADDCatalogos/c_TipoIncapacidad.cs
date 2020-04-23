using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.ADDCatalogos
{
    public class c_TipoIncapacidad
    {
        [Key]
        [Column(Order = 0)]
        public long IdElemento { get; set; }

        public int? IdCatalogo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CodigoReporting { get; set; }

        [StringLength(255)]
        public string Valor { get; set; }

        public DateTime? InicioVigencia { get; set; }

        public DateTime? FinVigencia { get; set; }
    }
}
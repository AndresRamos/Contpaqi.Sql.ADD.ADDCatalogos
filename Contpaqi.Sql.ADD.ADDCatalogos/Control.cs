using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.ADDCatalogos
{
    [Table("Control")]
    public class Control
    {
        [Key]
        public int IdCatalogo { get; set; }

        [StringLength(150)]
        public string Catalogo { get; set; }

        [StringLength(5)]
        public string Version { get; set; }

        public DateTime? FechaLanzamiento { get; set; }

        [StringLength(60)]
        public string Storage { get; set; }

        [StringLength(150)]
        public string TagReporting { get; set; }
    }
}
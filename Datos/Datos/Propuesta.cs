namespace Datos.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Propuesta")]
    public partial class Propuesta
    {
      

        [Key]
        public int IdPropuesta { get; set; }

        public int IdEmpresa { get; set; }

        public int IdContrato { get; set; }

        [Required]
        [StringLength(50)]
        public string FechaEntrega { get; set; }

     
    }
}

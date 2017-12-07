namespace Datos.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoUsuario")]
    public partial class TipoUsuario
    {
      

        [Key]
        public int IdTipo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

      
    }
}

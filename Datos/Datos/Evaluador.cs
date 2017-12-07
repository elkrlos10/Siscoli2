namespace Datos.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Evaluador")]
    public partial class Evaluador
    {

        [Key]
        public int IdEvaluador { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        public int IdUsuario { get; set; }

       
    }
}

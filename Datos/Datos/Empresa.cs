namespace Datos.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
     

        [Key]
        public int IdEmpresa { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Nit { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }

        public int? IdUsuario { get; set; }

    }
}

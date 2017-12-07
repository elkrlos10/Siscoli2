namespace Datos.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [Key]
        public int IdItem { get; set; }

        [StringLength(60)]
        public string NombreItem { get; set; }

        public int? IdPropuesta { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        public double? Calificacion { get; set; }

        public int IdEvaluador { get; set; }

    }
}
